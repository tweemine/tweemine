# -*- coding: utf-8 -*-

#Import the necessary methods from tweepy library
from tweepy.streaming import StreamListener
from tweepy import OAuthHandler
from tweepy import Stream
import tweepy

#Variables that contains the user credentials to access Twitter API 
access_token = "2730466444-k6CP3c6oh3ilGUeksuF8pgFZZULdJu5VGLbZt3e"
access_token_secret = "pcOZhhtBQLeKtUZolR4u0Mo6urJR9aYPDxsVXmwQ1hWBZ"
consumer_key = "ik6fmv37Gg21e4dHRV54B2VcO"
consumer_secret = "b34sTvlrbBFslkbnfVkJoxjunfV8cILw5m8fou8BAeMdtvPryp"

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
    










        
    
