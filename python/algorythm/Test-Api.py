import requests
import json
from datetime import date, timedelta
from dateutil.relativedelta import relativedelta
import re

#Wichtig
api_token = "demo"
fmt = "json"
period = "d"
filename = "result.json"
print("1. Geladen")


#API-Zugriff
today = date.today() - timedelta(days=1)
past = date.today() - relativedelta(years=15)
request = requests.get(f"https://eodhistoricaldata.com/api/eod/MCD.US?api_token={api_token}&fmt={fmt}&period={period}&from={past}&to={today}")
print("2. API hergestellt")

data = request.json()

for item in data:
    del item["open"]
    del item["high"]
    del item["low"]
    del item["adjusted_close"]
    del item["volume"]
#Convert dictionary "data" in string
s = json.dumps(data)
#Regex searching for all close data, saving in "x"
x = re.findall('"close": [0-9\.]*', s)
#Converting list "x" in string
y = "".join(x)
#Regex searching for the closing price, cutting "close" off
#TODO: Converting the closing price in "int", at the time it's "string"
z = re.findall('[0-9\.]+', y)
print(z)

print("3. Manipuliert")




#Datum manipulieren, Wochenenden ausfüllen mit Vortagswert
i = 0
date = past

for item in data:
    print("Start! i= ", i, "Datum: ", date )
    datum = date.strftime("%Y-%m-%d")
    if item["date"] != datum:
        print("Fehler")
        price = item["close"]
        data[i].insert({f"date": "{date}", "close": {price}})
    else:
        print("Kein Fehler")
    date = date + timedelta(days=1)
    i = i + 1

    


with open(filename, "w") as file:
    json.dump(data, file)

print("4. Gespeichert")