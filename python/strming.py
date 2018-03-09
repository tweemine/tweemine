# -*- coding: utf-8 -*-

#Import the necessary methods from tweepy library
from tweepy.streaming import StreamListener
from tweepy import OAuthHandler
from tweepy import Stream
import json
import codecs
import tweepy
filterList=[u'a',u'üzgün',u'sinirli',u'agresif',u'hüzünlü',u'mutsuz',u'hüzün',u'sakin'  ]
#Variables that contains the user credentials to access Twitter API

#nothing is correct
access_token = "2730466444-k6CP3c6asdsadasdasdoh3ilGUeksdJu5VGLbZt3e"
access_token_secret = "pcOZhhtBQLasdasdasdasdasdeKtUZolR4u0Mo6urJDxsVXmwQ1hWBZ"
consumer_key = "asdasasdasd"
consumer_secret = "b34sTvlrbBFslkasdasdasdbnfVkJoxjunfV8cILwMdtvPryp"
#nothing is correct
counter = 0

f = open("tweets.txt","w")
#This is a basic listener that just prints received tweets to stdout.
class StdOutListener(StreamListener):
    
    def on_status(self, status):
        try:
            text = status.extended_tweet["full_text"].encode('utf-8')
            #f.write("Username: " + status.user.screen_name +"\n")
            data={'Tweet': text }
            json.dump(data,f,ensure_ascii=False)
            print text
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
    










        
    
