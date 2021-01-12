# -----------------#
import os
import time
import platform
import sys
import psutil
import subprocess as sp


# -----------------#


def clear():
    if platform.system() == "Windows":
        tmp = sp.call('cls', shell=True)  # Windows call
    else:
        tmp = sp.call('clear', shell=True) # *nix call


print("Welcome to Bin.py, please wait...")
time.sleep(5)
print("=" * 40, "System Information", "=" * 40)
uname = platform.uname()
print(f"System: {uname.system}")
print(f"Node Name: {uname.node}")
print(f"Release: {uname.release}")
print(f"Version: {uname.version}")
print(f"Machine: {uname.machine}")
print(f"Processor: {uname.processor}")
print("=" * 100)
time.sleep(5)
clear()
