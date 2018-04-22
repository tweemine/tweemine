﻿using System;
using Newtonsoft.Json;
namespace TweemineNeuralNetwork
{
    [Serializable]
	public class NeuralNetwork
	{
        private int inputNodes;
        private int hiddenNodes;
        private int outputNodes;

        double learningRate;

        private Matrix weights_ih;
        private Matrix weights_ho;
        private Matrix bias_h;
        private Matrix bias_o;

        public double LearningRate { get => learningRate;  set => learningRate = value; }
        public int InputNodes { get => inputNodes;   set => inputNodes = value; }
        public int HiddenNodes { get => hiddenNodes;   set => hiddenNodes = value; }
        public int OutputNodes { get => outputNodes;   set => outputNodes = value; }
        public Matrix Weights_ih { get => weights_ih;   set => weights_ih = value; }
        public Matrix Weights_ho { get => weights_ho;   set => weights_ho = value; }
        public Matrix Bias_h { get => bias_h;   set => bias_h = value; }
        public Matrix Bias_o { get => bias_o;   set => bias_o = value; }
        //we need this for serialization
        public NeuralNetwork()
        {
        }
        public NeuralNetwork(int inputNodes, int hiddenNodes, int outputNodes, double learningRate)
		{
			this.inputNodes  = inputNodes;
			this.hiddenNodes = hiddenNodes;
			this.outputNodes = outputNodes;

			this.learningRate = learningRate;
		
			weights_ih = new Matrix(hiddenNodes, inputNodes);
			weights_ho = new Matrix(outputNodes, hiddenNodes);
			weights_ih.Randomize();
			weights_ho.Randomize();

			bias_h = new Matrix(this.hiddenNodes, 1);
			bias_o = new Matrix(this.outputNodes, 1);
			bias_h.Randomize();
			bias_o.Randomize();
		}

		public NeuralNetwork(NeuralNetwork nn)
		{
			this.inputNodes = nn.inputNodes;
			this.hiddenNodes = nn.hiddenNodes;
			this.outputNodes = nn.outputNodes;

			this.learningRate = nn.learningRate;
            
			this.weights_ih = new Matrix(nn.weights_ih);
			this.weights_ho = new Matrix(nn.weights_ho);
			this.bias_h = new Matrix(nn.bias_h);
			this.bias_o = new Matrix(nn.bias_o);
		}

		public double[] FeedForward(double[] inputArray)
		{
			// Generating the hidden outputs.
			Matrix input = Matrix.FromArray(inputArray);
			Matrix hidden = Matrix.MatrixProduct(this.weights_ih, input);
			hidden += this.bias_h;
			hidden.Map(Sigmoid);

			// Generating the output's output.
			Matrix output = Matrix.MatrixProduct(this.weights_ho, hidden);
			output += this.bias_o;
			output.Map(Sigmoid);

			return Matrix.ToArray(output);
		}

		public void Train(double[] inputArray, double[] targetArray)
		{
			// FeedForward Process
			// Generating the hidden outputs.
			Matrix input = Matrix.FromArray(inputArray);
			Matrix out_hid = Matrix.MatrixProduct(this.weights_ih, input);
			out_hid += this.bias_h;
			out_hid.Map(Sigmoid);

			// Generating the output's output.
			Matrix outs_out = Matrix.MatrixProduct(this.weights_ho, out_hid);
			outs_out += this.bias_o;
			outs_out.Map(Sigmoid);

			Matrix target = Matrix.FromArray(targetArray);


			// Backpropagation Process
			Matrix neto_d_E = (outs_out - target) * Matrix.Map(outs_out, DerSigmoid);

			Matrix wo_d_neto = Matrix.Map(out_hid, DerNetFunc);

			Matrix wo_d_E = Matrix.MatrixProduct(neto_d_E, Matrix.Transpose(wo_d_neto));

			Matrix outh_d_neto = Matrix.Map(weights_ho, DerNetFunc);

			weights_ho = weights_ho - (learningRate * wo_d_E);

			//Console.WriteLine(weights_ho);

			Matrix outh_d_E = Matrix.MatrixProduct(Matrix.Transpose(outh_d_neto), neto_d_E);

			Matrix neth_d_outh = Matrix.Map(out_hid, DerSigmoid);

			Matrix neth_d_E = outh_d_E * neth_d_outh;

			Matrix wh_d_neth = Matrix.Map(input, DerNetFunc);

			Matrix wh_d_E = Matrix.MatrixProduct(wh_d_neth, Matrix.Transpose(neth_d_E));

			weights_ih = weights_ih - (learningRate * Matrix.Transpose(wh_d_E));
		}

		public double GetError(Matrix target, Matrix output)
		{
			// Calculate the error 
			// ERROR = (1 / 2) * (TARGETS - OUTPUTS)^2

			Matrix outputError = target - output;
			outputError = (outputError * outputError) / 2.0;

			double error = 0.0;
			for(int i = 0; i < outputError.data.GetLength(0); i++)
				error += outputError.data[i, 0];

			return error;
		}

        public static double Tanh(double x)
        {
            return 2f / (1f + Math.Exp(-2f * x)) - 1f;
        }

        public static double DerTanh(double x)
        {
            double tanh = Tanh(x);

            return 1f - tanh * tanh;
        }

        public static double Sigmoid(double x)
		{
			return 1.0 / (1.0 + Math.Exp(-x));
		}

		public static double DerSigmoid(double x)
		{
			return x * (1.0 - x);
		}

		public static double DerNetFunc(double x)
		{
			return x;
		}
	}
}

