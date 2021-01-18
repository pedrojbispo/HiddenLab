# -----------------#
import os
import time
import platform
import sys
import psutil
import subprocess as sp
import database


# -----------------#


def clear():
    if platform.system() == "Windows":
        tmp = sp.call('cls', shell=True)  # Windows call
    else:
        tmp = sp.call('clear', shell=True) # *nix call

def TurmaMostrar():
    cont = 1
    print()
    for i in database.turma:
        print(str(cont) + "-> " + str(i))
        cont+=1
    print()


print("Welcome to Bin.py, please wait...")
time.sleep(1)
print("=" * 40, "System Information", "=" * 40)
uname = platform.uname()
print(f"System: {uname.system}")
print(f"Node Name: {uname.node}")
print(f"Release: {uname.release}")
print(f"Version: {uname.version}")
print(f"Machine: {uname.machine}")
print(f"Processor: {uname.processor}")
print("=" * 100)
time.sleep(1)
clear()
