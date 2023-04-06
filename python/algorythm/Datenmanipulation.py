datei = open('result.json', 'r')

dateiread = datei.read()
einzelnsplit = dateiread.split('}')
finishedsplit = dateiread.split(',')
print(einzelnsplit[5])
print(finishedsplit[4])