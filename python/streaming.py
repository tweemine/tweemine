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

access_token = "XXXXXXXXXXXX-XXXXXXXXXXXXX"
access_token_secret = "XXXXXXXXXXXXXXXXXXXX"
consumer_key = "XXXXXXXXXXXXXXXXXX"
consumer_secret = "XXXXXXXXXXXXXXXXXXXXX"

listOfData=[]
f = open("tweets.json","w")

sport    = [ u'gol', u'hakem', u'turnuva', u'raket', u'galatasaray', u'lig', u'nba', u'uefa', u'puan durumu' ]
news     = [ u'son dakika', u'haber', u'muhabir', u'nato' ]
history  = [ u'osmanlı', u'ortaçağ', u'm.ö.', u'm.s.', u'yılında', u'uygarlığı' ]
tvSeries = [ u'dizi', u'film', u'gişe', u'imdb', u'spoiler', u'twd', u'himym' ]
music    = [ u'dinledim', u'spotify', u'playlist', u'şarkı', u'akor' ]

#This is a basic listener that just prints received tweets to stdout.
class StdOutListener(StreamListener):

    def on_status(self, status):
        try:
            text = status.extended_tweet["full_text"].encode('utf-8')
        except AttributeError:
            text = status.text.encode('utf-8')
        
        if(text.startswith('RT')):
            return
        
        data = {'tweet': text, 'labeled': False, 'words': [], 'users': []}
        listOfData.append(data)
        print text
        print "\n"

        if len(listOfData) >= 20:
            sys.exitfunc()

            
    def on_error(self, status):
        print(status)

        
def saver():
    json.dump(listOfData,f,ensure_ascii=False)
    print "exit"
    quit()

if __name__ == '__main__':
    
    atexit.register(saver)
    
    #This handles Twitter authetification and the connection to Twitter Streaming API
    l = StdOutListener()
    auth = OAuthHandler(consumer_key, consumer_secret)
    auth.set_access_token(access_token, access_token_secret)
    stream = Stream(auth,l,tweet_mode = 'extended',truncated = 'false')
    
stream.filter( track = sport, languages = ['tr'] )
