#-----------------#
import os
import time
import platform
import sys
import psutil
#-----------------#


def clear():
    if platform.system() == "Windows":
        os.system('cls')
    else:
        os.system('clear')


print("Welcome to Bin.py, please wait...")
time.sleep(5)
print("="*40, "System Information", "="*40)
uname = platform.uname()
print(f"System: {uname.system}")
print(f"Node Name: {uname.node}")
print(f"Release: {uname.release}")
print(f"Version: {uname.version}")
print(f"Machine: {uname.machine}")
print(f"Processor: {uname.processor}")
print("="*100)
time.sleep(5)
clear()