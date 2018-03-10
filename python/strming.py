# -*- coding: utf-8 -*-

#Import the necessary methods from tweepy library
from tweepy.streaming import StreamListener
from tweepy import OAuthHandler
from tweepy import Stream
import json
import codecs
import tweepy
import atexit
import sys
filterList=[u'a',u'üzgün',u'sinirli',u'agresif',u'hüzünlü',u'mutsuz',u'hüzün',u'sakin'  ]
#Variables that contains the user credentials to access Twitter API

#nothing is correct
access_token = "sdf-dsf"
access_token_secret = "sdf"
consumer_key = "sdf"
consumer_secret = "dsf"
#nothing is correct
counter = 0
listOfData=[]
f = open("tweets.json","w")
#This is a basic listener that just prints received tweets to stdout.
class StdOutListener(StreamListener):
    countData=0
    def on_status(self, status):
        try:
            text = status.extended_tweet["full_text"].encode('utf-8')
            #f.write("Username: " + status.user.screen_name +"\n")
            data={'Tweet': text }
            listOfData.append(data)
            print text
            #f.flush()
            if len(listOfData) >= 10:
                sys.exitfunc()
                

        except AttributeError:
            text = status.text    
    def on_error(self, status):
        print(status ,'hatasi')

        
def saver():
    json.dump(listOfData,f,ensure_ascii=False)
    print "exit"
    quit()

if __name__ == '__main__':
	    
    #This handles Twitter authetification and the connection to Twitter Streaming API
    atexit.register(saver)
    l = StdOutListener()
    auth = OAuthHandler(consumer_key, consumer_secret)
    auth.set_access_token(access_token, access_token_secret)
    stream = Stream(auth,l,tweet_mode = 'extended',truncated= 'false')
    #This line filter Twitter Streams to capture data by the keywords: 'python', 'javascript', 'ruby'
    stream.filter(track=filterList,languages = ['tr'])
    







    



    








        
    
