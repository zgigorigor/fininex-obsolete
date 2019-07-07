####################################################################################
#   Title:                      Troskovi ######   Version:    2.0.1                #
##################################################   Author:     Igor Bistrovic ####
##############################################################   Date: 2018-01-20  #
#   About:                                          Unos troskova po kategorijama  #
####################################################################################
#   Update: 18-04-29   zbraja unose troskova, ispisuje total dana u logu, izvodi se u petlji #
####################################################################################

import logging
import time

logging.basicConfig(level=logging.DEBUG,
                    datefmt='%Y-%m-%d %a %H:%M:%S', 
                    format='%(asctime)s %(levelname)-8s %(message)s',
                    filename='D:/dev/logs/log-demo_troskovi.txt',
                    #filename='D:/dev/logs/log-fininex-test.txt',
                    #filename='D:/dev/logs/log-fininex.txt',
                    )
#logging.info('info')
#logging.debug('radnje')
#logging.warning('upozorenja')

logging.debug('Start of application.')

num1 = 0

trosak_date_upit = input ("Danasnji datum? ")
if trosak_date_upit=="da":
    trosak_date = time.strftime("%Y-%m-%d")
    #logging.warning('%s | ..test1' %trosak_date)
else:
    god = input ("Upisi datum (yyyy-mm-dd):\n-godina: ")
    mj = input ("-mjesec: ")
    dan = input ("-dan: ")
    trosak_date = ('%s-%s-%s' %(god, mj, dan))
    #logging.warning('%s | ..test2' %trosak_date)

while True:
    trosak= input('Jos racuna? ')
    if trosak=='ne':
        input ("\nUnos troskova zavrsen. Pritisnite Enter za nastavak.")
        break
    elif True:
    #if True:
    #if trosak==True:
    #if trosak=="da":
        iznos_trosak = input("Iznos kupovine (n,nn): ")
        #logging.warning('%s | - | %s ..test' %(trosak_date, iznos_trosak))
        num2 = iznos_trosak
        sum = float(num1) + float(num2)
        total_trosak_temp = sum
        num1 = total_trosak_temp

        valuta_trosak = input ("Valuta:\n1) kuna\n2) dolar\n3) euro\n")
        if valuta_trosak=="1":
            valuta_trosak = 'HRK'
        elif valuta_trosak=="2":
            valuta_trosak = 'USD'
        elif valuta_trosak=="3":
            valuta_trosak = 'EUR'
        else:
            input("\nNepodrzana valuta.\nPritisnit Enter za nastavak...")
            logging.warning('%s | - | %s !!! (%s) !!! | nepodrzana valuta.' %(trosak_date, iznos_trosak, valuta_trosak))
        #logging.warning('%s | - | %s (%s) | ..test' %(trosak_date, iznos_trosak, valuta_trosak))
        oznaka = input("Odaberi identifikator troska:\n1) hrana\n2) online shopping\n3) neplanirani troskovi\n4) POINTER\n5) rezije\n6) ostalo\n")
        if oznaka=="1":
            oznaka = 'HRA'
            hra = input("Info:\n1)konzum\n2)gablec\n3)spar\n4)drugo\n")
            if hra=="1":
                info = 'konzum'
            elif hra=="2":
                info = 'gablec'
            elif hra=="3":
                info = 'spar'
            else:
                info = input("Info: ")
        elif oznaka=="2":
            oznaka = 'OSH'
            info = input("Info: ")
        elif oznaka=="3":
            oznaka = 'NTR'
            info = input("Info: ")
        elif oznaka =="4":
            oznaka = 'POI'
            info = input("Info: ")
        elif oznaka=="5":
            oznaka = 'REZ'
            info = input("Info: ")
        elif oznaka=="6":
            oznaka = 'OST'
            info = input("Info: ")
        else:
            oznaka = 'Ukn'
            logging.warning('%s | - | %s (%s) | %s | nepostojeca oznaka' % (trosak_date, iznos_trosak, valuta_trosak, oznaka))
            pass
        #logging.warning('%s | - | %s (%s) | %s | ..test' % (trosak_date, iznos_trosak, valuta_trosak, oznaka))

        #info = input("Info: ")
        logging.info('%s | - | %s (%s) | %s | %s' % (trosak_date, iznos_trosak, valuta_trosak, oznaka, info))
    else:
        input ("\nNepoznati unos.")
    #total_trosak=iznos_trosak
#input ("\nUnos trosaka zavrsen. Pritisnite Enter za nastavak.")
total_trosak = total_trosak_temp
logging.info('%s | - | %s (%s) | TOT | total-dana' % (trosak_date, total_trosak, valuta_trosak ))
logging.debug('End of application.')

#note:
# program se mora izvoditi u petlji

# na kraju programa total unesenog
#total_trosak=zbroj_trosak
#logging.info('%s | ? | %s (%s) | TOT | total-dana' % (trosak_date, total_trosak, valuta_trosak))