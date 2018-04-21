#!/usr/bin/env python2
# -*- coding: utf-8 -*-
#Import the necessary methods from tweepy library
import tweepy
from tweepy.streaming import StreamListener
from tweepy import OAuthHandler
from tweepy import Stream
from tweepy import API
import json
import codecs
import tweepy
import atexit
import sys
import random

#Variables that contains the user credentials to access Twitter API 
access_token = "2387554910-QZOusvtVxaaXU0dIPEO0ij247D8heARHfM26yHy"
access_token_secret = "ovYb0LAjxFM6HqIKMulpJEP16tbDZvMqIoAuPEON4eoT3"
consumer_key = "OnccjMQNxxJw9x5T1UC9BiJ6l"
consumer_secret = "gmI2qwpTTLw2stqw9Jfh9N3PfIEewtDa1ky7omACUY9jbxtJFV"
listOfData=[]
nameofFile=str(random.randint(0,1000))+" "+str(random.randint(0,1000));
f = open("..\\tweets\\"+str(nameofFile)+".json","w")

def saver():
    json.dump(listOfData,f,ensure_ascii=False)
    print "exit"
    quit()

if __name__ == "__main__":
    auth = tweepy.OAuthHandler(consumer_key, consumer_secret)
    auth.set_access_token(access_token, access_token_secret)
    api = tweepy.API(auth)
    
    tweets = api.user_timeline(screen_name='tarihdergi',count = 10,tweet_mode = 'extended')
    for tweet in tweets:
        if (tweet.full_text.startswith('RT')):
            continue
        text = tweet.full_text.encode('utf-8')
        data = {'tweet': text, 'labeled': False, 'words': [], 'users': [{'name':"Default",'labels':None}]}
        listOfData.append(data)
        print text
        print '\n'
    saver()
