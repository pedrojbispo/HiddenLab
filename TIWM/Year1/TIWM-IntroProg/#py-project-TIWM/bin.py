# -----------------#
import os
import time
import platform
import sys
import psutil
import subprocess as sp
import database
import wmi

# -----------------#

def clear():
    if platform.system() == "Windows":
        tmp = sp.call('cls', shell=True)  # Windows call
    else:
        tmp = sp.call('clear', shell=True)  # *nix call


def LerFicheiro(fichName):
    if os.path.isfile(fichName):
        f = open(fichName, "r")
        linha = f.readline()

        while linha != "":
            vL = linha.split('|')
            varpauta = database.Pauta(vL[0], (vL[1]), (vL[2]), int(vL[3]), int(vL[4]), int(vL[5]), (vL[6]), str(vL[7]))
            database.listapauta.append(varpauta)
            linha = f.readline()

        f.close()


def GuardarFicheiro(fichName):
    f = open(fichName, "w")
    for i in database.listapauta:
        f.write(i.StringFicheiro())
    f.close()


caminho = "dadosKSC.txt"


def Mostraturma():
    cont = 1
    print()
    for i in database.listaturmas:
        print(str(cont) + "-> " + str(i))
        cont += 1
    print()


def Mostraaluno():
    cont = 1
    print()
    for i in database.listaalunos:
        print(str(cont) + "-> " + str(i))
        cont += 1
    print()


def Mostradisciplina():
    cont = 1
    print()
    for i in database.listadisciplinas:
        print(str(cont) + "-> " + str(i))
        cont += 1
    print()


def Mostrapauta():
    cont = 1
    print()
    for i in database.listapauta:
        print(str(cont) + "-> " + str(i))
        cont += 1
    print()


print("Welcome to Bin.py, please wait...")
time.sleep(1)

uname = platform.uname()
computer = wmi.WMI()
computer_info = computer.Win32_ComputerSystem()[0]
os_info = computer.Win32_OperatingSystem()[0]
proc_info = computer.Win32_Processor()[0]
gpu_info = computer.Win32_VideoController()[0]

os_name = os_info.Name.encode('utf-8').split(b'|')[0]
os_version = ' '.join([os_info.Version, os_info.BuildNumber])
system_ram = float(os_info.TotalVisibleMemorySize) / 1048576  # KB to GB
print("=" * 40, "System Information", "=" * 40)
print(f"System: {uname.system}")
print(f"Node Name: {uname.node}")
print(f"Release: {uname.release}")
print(f"Version: {uname.version}")
print(f"Machine: {uname.machine}")
print('CPU: {0}'.format(proc_info.Name))
print('RAM: {0} GB'.format(system_ram))
print('Graphics Card: {0}'.format(gpu_info.Name))
print("=" * 100)
time.sleep(1)
clear()
