import tkinter as tk
import requests

import datetime
import time
from newsapi import NewsApiClient root = tk.Tk() root.geometry(”1920x1080”) root.configure(bg=”black”) colorbg=’black’ textcolor=’white’
def NewsFromBBC(): BBC news api

 
mainurl = ”https : //newsapi.org/v1/articles?source = bbc topapiKey = 4dbc17e007ab436fb66416009df b59a8”
fetching data in json format


openbbcpage = requests.get(mainurl).json()
getting all articles in a string article article = openbbcpage[”articles”]


empty list which will contain all trending news results = []
for ar in article: results.append(ar[”title”]) return results
class dt():
def mydate(): t=datetime.datetime.now().date() return t def mytime():
timestring = time.strftime(” return timestring

class Weather(): def temp(): x=”39”+chr(176)+”C” return x
 
− newssortBy =
w = tk.Label(root, text=dt.mydate(), bg=colorbg, fg=textcolor,font=(”Liberation Serif”,
26))


w.pack(fill=tk.Y, pady=10,anchor=’e’) w = tk.Label(root,text=dt.mytime(), bg=colorbg, fg=textcolor,font=(”Liberation Serif”, 26))

w.pack(fill= tk.Y,pady=10,anchor=’se’) w = tk.Label(root, text=Weather.temp(), bg=colorbg, fg=textcolor,font=(”Liberation Serif”, 26))

w.pack(fill=tk.Y, pady=10,anchor=’e’) w = tk.Label(root, text=”Breaking NEWS ”, bg=colorbg, fg=textcolor,font=(”Liberation Serif”, 26))

w.pack(fill=tk.Y, pady=10,anchor=’s’) sam=NewsFromBBC() for i in range(len(sam)): temp=sam[i]

 

26))
 
w= tk.Label(root, text=””+temp, bg=colorbg, fg=textcolor,font=(”Liberation Serif”,


w.pack(fill=tk.Y, pady=10,anchor=’s’,side=’bottom’) w.mainloop()
