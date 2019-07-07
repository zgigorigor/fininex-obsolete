##########################################
#   Title:                       Fininex #
#####   Version:    2.0.0                #
##########################################
########   Author:     Igor Bistrovic ####
####################   Date: 2018-01-20  #
##########################################
#   About:      unos prihoda i troskova  #
##########################################
#   Update:          python 3 compatible #
##########################################

import logging #podesiti path i poruke
import time
import os

logging.basicConfig(level=logging.DEBUG,
                    datefmt='%Y-%m-%d %a %H:%M:%S', 
                    format='%(asctime)s %(levelname)-8s %(message)s',
                    filename='C:/Software/logs/log-demo_fininex.txt',
                    #filename='C:/Software/logs/log-fininex-test.txt',
                    #filename='C:/Software/logs/log-fininex.txt',
                    )
#logging.info('info')
#logging.debug('radnje')
#logging.warning('upozorenja')

logging.debug('Start of application.')

fininex_start = input("Pokrenuti Fininex_v.2.0.0? ")
if fininex_start=="da":
    date_upit = input ("Danasnji datum? ")
    if date_upit=="da":
        date = time.strftime("%Y-%m-%d")
    #    logging.warning('%s | ..test1' %date)
    else:
        god = input ("Upisi datum (yyyy-mm-dd):\n-godina: ")
        mj = input ("-mjesec: ")
        dan = input ("-dan: ")
        date = ('%s-%s-%s' %(god, mj, dan))
    #    logging.warning('%s | ..test2' %date)

    prihod = input ("Prihod? ")
    if prihod=="da":
        os.system('python C:/Software/dev/fininex/prihodi.py')
        logging.debug('prihodi.py executed')
        while True:
            dod_prihod = input('Jos prihoda? ')
            if dod_prihod =='da':
                os.system('python C:/Software/dev/fininex/prihodi.py')
                logging.debug('prihodi.py executed')
            else:
                #prihod_total = 
                logging.warning('gotov unos prihoda.')
                break
    else:
        iznos = '0,00'
        valuta = '---'
        logging.info('%s | + | %s (%s) | x | nema prihoda.' % (date, iznos, valuta))

    trosak = input('Zelis upisati trosak? ')
    if trosak=="da":
        os.system('python C:/Software/dev/fininex/troskovi.py')
        logging.debug('troskovi.py executed')
        while True:
            dod_trosak = input('Jos racuna? ')
            if dod_trosak=="da":
                os.system('python C:/Software/dev/fininex/troskovi.py')
                logging.debug('troskovi.py executed')
            else:
                #trosak_total =
                logging.warning('gotov unos troskova.')
                break
    else:
        #trosak = '0,00'
        logging.warning('%s | - | %s (%s) | x | nema troskova.' % (date, iznos, valuta))
else:
    input("\nPritisni Enter za izlaz.")
    returncode=0
logging.debug('End of application.')

#         - izracunavanje dnevnog totala #


#else:
#    prihod_date = time.strftime("%Y-%m-%d")
#    raise SystemExit("Nema prihoda. Izlazim.")

#    prihod = input ("Iznos: ")
#    valuta_plus = input ("\nValuta(kn, euro, dolar): ")
#    if valuta_plus=="kn":
#        valuta_plus = 'HRK'
#    elif valuta_plus=="euro":
#        valuta_plus = 'EUR'
#    elif valuta_plus=="dolar":
#        valuta_plus = 'USD'
#    else:
#        input("\nNepodrzana valuta.\nPritisnit Enter za nastavak...")
#        logging.warning('Nepodzana-valuta "%s"' %valuta_plus)
#else:
#    pass
#    valuta_plus = '0,00'
#info_plus = input ("\nIzvor prihoda:\n1) Bankomat\n2) POINTER\n3) Ostalo")



#valuta_plus = input ("\nValuta(kn, euro, dolar): ")
#if valuta_plus=="kn":
#    valuta_plus = 'HRK'
#elif valuta_plus=="euro":
#    valuta_plus = 'EUR'
#elif valuta_plus=="dolar":
#    valuta_plus = 'USD'
#else:
#    input("\nNepodrzana valuta.\nPritisnit Enter za nastavak...")
#    logging.warning('Nepodzana-valuta "%s"' %valuta_plus)


            #logging.info('%s | +%s %s|' % (datum, prihod, valuta_plus))

#iznos = input ("\nUnesi iznos racuna: ")
#oznaka = input ("\nOdaberi oznaku: ")
#info = input ("\nDodatne informacije: ")

#logging.info('%s | ' %datum)