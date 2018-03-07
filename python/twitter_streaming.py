# -*- coding: utf-8 -*-

#Import the necessary methods from tweepy library
from tweepy.streaming import StreamListener
from tweepy import OAuthHandler
from tweepy import Stream
import tweepy

#Variables that contains the user credentials to access Twitter API 
access_token = "XXXXXXXXXXXX-XXXXXXXXXXXXX"
access_token_secret = "XXXXXXXXXXXXXXXXXXXX"
consumer_key = "XXXXXXXXXXXXXXXXXX"
consumer_secret = "XXXXXXXXXXXXXXXXXXXXX"

filterList=[u'mutlu',u'üzgün',u'sinirli',u'agresif',u'hüzünlü',u'mutsuz']

f=open("streamingData.txt","w")

#This is a basic listener that just prints received tweets to stdout.
class StdOutListener(StreamListener):

    def on_status(self, data):
        f.write("Username: " + data.user.screen_name +"\n")
        f.write("Tweet: " + data.text.encode("utf8") + "\n\n")

        return True

    def on_error(self, status):
        print(status)


if __name__ == '__main__':
	    
    #This handles Twitter authetification and the connection to Twitter Streaming API
    l = StdOutListener()
    auth = OAuthHandler(consumer_key, consumer_secret)
    auth.set_access_token(access_token, access_token_secret)
    api = tweepy.API(auth)
    stream = Stream(auth, l)


    stream.filter(track=filterList, languages = ['tr'])
    










        
    
