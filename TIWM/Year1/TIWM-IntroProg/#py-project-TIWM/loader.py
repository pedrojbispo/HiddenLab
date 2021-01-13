import bin
import time


def banner():
    Sbanner = open("assets/banner.txt", "r", encoding="utf8")
    print(Sbanner.read(), "\n")
    Sbanner.close()


def into():
    Sinto = open("assets/intro.txt", "r", encoding="utf8")
    print(Sinto.read(), "\n")
    Sinto.close()


into()
time.sleep(1)
bin.clear()
