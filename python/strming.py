# -*- coding: utf-8 -*-

#Import the necessary methods from tweepy library
from tweepy.streaming import StreamListener
from tweepy import OAuthHandler
from tweepy import Stream
import tweepy
filterList=[u'mutlu',u'üzgün',u'sinirli',u'agresif',u'hüzünlü',u'mutsuz',u'hüzün',u'sakin'  ]
#Variables that contains the user credentials to access Twitter API 
access_token = "xxx"
access_token_secret = "oxxx"
consumer_key = "Oxxxl"
consumer_secret = "xxx"

counter = 0

f = open("twitlerv2.txt","a")
#This is a basic listener that just prints received tweets to stdout.
class StdOutListener(StreamListener):

   # def on_status(self, data):
        #print data
    #    global counter
        #print 'counter: ' + counter
        #print(data.created_at)
        #print(data.text)
        #f.write("\n\n "+ data.user.screen_name +"\n\n")
        #f.write(data.text.encode("utf8"))
        #printdata.user.screen_name
        ##counter += 1
        
        
        #b = dir(data)
        #for a in b:
         #   print a


      
     #   return True

    def on_status(self, status):
        try:
            text = status.extended_tweet["full_text"].encode('utf8')
            print text
            f.write(text+"\n\n")
            f.flush()
        except AttributeError:
            text = status.text    
    def on_error(self, status):
        print(status ,'hatasi')

if __name__ == '__main__':
	    
    #This handles Twitter authetification and the connection to Twitter Streaming API
    l = StdOutListener()
    auth = OAuthHandler(consumer_key, consumer_secret)
    auth.set_access_token(access_token, access_token_secret)
    stream = Stream(auth,l,tweet_mode = 'extended',truncated= 'false')
    #This line filter Twitter Streams to capture data by the keywords: 'python', 'javascript', 'ruby'
    stream.filter(track=filterList,languages = ['tr'])
    










        
    
