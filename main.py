import gspread
import numpy as np

gc = gspread.service_account(filename="unity-caimanchic-91c5ae548f7e.json")
sh = gc.open("UnitySheets")
price = np.random.randint(2000, 10000, 11)
mon = list(range(1, 11))

i = 0
while i <= len(mon):
    i += 1
    if i == 0:
        continue
    else:
        temp_inf = ((price[i - 1] - price[i - 2]) / price[i - 2]) * 1000
        temp_inf = str(temp_inf)
        temp_inf = temp_inf.replace('.', ',')
        sh.sheet1.update(('A' + str(i)), str(i))
        sh.sheet1.update(('B' + str(i)), str(price[i - 1]))
        sh.sheet1.update(('C' + str(i)), str(temp_inf))
        print(temp_inf)