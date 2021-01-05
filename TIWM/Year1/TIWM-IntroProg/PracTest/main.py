op = " "
region = {}
region.update({"a": [15, 25, 25]})
region.update({"b": [5, 15, 85]})
region.update({"c": [1, 10, 90]})
region.update({"d": [18, 30, 0]})
region.update({"e": [16, 28, 5]})

while op != "0":
    print("Menu")
    print("\t1- Add Reg")
    print("\t2- Remove Reg")
    print("\t3- Show Reg")
    print("\t4- Max Reg")
    print("\t5- Min Reg")
    print("\t6- Avg Reg")
    print("\t7- IsRaining Reg")
    print("\t0- Exit")

    op = input("Option: ")
    print("")
    if op == "1":
        print("Add Reg Started")
        RegionName = input("Region Name: ")
        MinTemp = int(input("Min Temp: "))
        MaxTemp = int(input("Max Temp: "))
        IsRaining = int(input("Rain Percent: "))
        region.update({RegionName: [MinTemp, MaxTemp, IsRaining]})
        print("Add Reg Completed\n")
    elif op == "2":
        print("Remove Reg Started")
        try:
            for i in region:
                print(i + ":")
                print("Temp Min: ", region[i][0], "ºC")
                print("Temp Max: ", region[i][1], "ºC")
                print("Rain: ", region[i][2], "%")
            remove = input("Region: ")
            del region[remove]
        except:
            print("Region not found, ERROR Code: 404\n")
        print("Remove Reg Completed\n")
    elif op == "3":
        print("Show Reg Started")
        for i in region:
            print(i + ":")
            print("Temp Min: ", region[i][0], "ºC")
            print("Temp Max: ", region[i][1], "ºC")
            print("Rain: ", region[i][2], "%")
        print("Remove Reg Completed\n")
    elif op == "4":
        print("Max Reg Started")
        tempMAX = list(region.keys())[0]
        for i in region:
            if region[tempMAX][1] < region[i][1]:
                tempMAX = i
        print(tempMAX + ":")
        print("\tTemp Min: ", region[tempMAX][0], "ºC")
        print("\tTemp Max: ", region[tempMAX][1], "ºC")
        print("\tRain: ", region[tempMAX][2], "%")
        print("Max Reg Completed\n")
    elif op == "5":
        print("Min Reg Started")
        tempMIN = list(region.keys())[0]
        for i in region:
            if region[tempMIN][1] > region[i][0]:
                tempMIN = i
        print(tempMIN + ":")
        print("\tTemp Min: ", region[tempMIN][0], "ºC")
        print("\tTemp Max: ", region[tempMIN][1], "ºC")
        print("\tRain: ", region[tempMIN][2], "%")
        print("Max Reg Completed\n")
    elif op == "6":
        print("Avg Reg Started")
        avg = 0

    elif op == "7":
        print("IsRaining Reg Started")
        for i in region:
            if region[i][2] > 75:
                RainMAX = i
        print(RainMAX + ":")
        print("\tTemp Min: ", region[RainMAX][0], "ºC")
        print("\tTemp Max: ", region[RainMAX][1], "ºC")
        print("\tRain: ", region[RainMAX][2], "%")
        print("IsRaining Reg Completed\n")
    else:
        print("ERROR: Invalid syntax. This program only accepts numbers.")
