####################################################################################
#   Title:                       Prihodi ######   Version:    2.0.0                #
##################################################   Author:     Igor Bistrovic ####
##############################################################   Date: 2018-01-20  #
#   About:                                           Unos prihoda po kategorijama  #
####################################################################################
#   Update:                                                    python 3 compatible #
####################################################################################

import logging
import time

logging.basicConfig(level=logging.DEBUG,
                    datefmt='%Y-%m-%d %a %H:%M:%S', 
                    format='%(asctime)s %(levelname)-8s %(message)s',
                    #filename='C:/Software/logs/log-demo_prihodi.txt',
                    filename='D:/dev/logs/log-demo_prihodi.txt',
                    #filename='C:/Software/logs/log-fininex-test.txt',
                    #filename='C:/Software/logs/log-fininex.txt',
                    )
#logging.info('info')
#logging.debug('radnje')
#logging.warning('upozorenja')

logging.debug('Start of application.')

prihod = input ("\nPokrenuti unos prihoda? ")
if prihod=="da":
    
    prihod_date_upit = input ("Danasnji datum?")
    if prihod_date_upit=="da":
        prihod_date = time.strftime("%Y-%m-%d")
#        logging.warning('%s | ..test1' %prihod_date)
    else:
        god = input ("Upisi datum (yyyy-mm-dd):\n-godina: ")
        mj = input ("-mjesec: ")
        dan = input ("-dan: ")
        prihod_date = ('%s-%s-%s' %(god, mj, dan))
#        logging.warning('%s | ..test2' %prihod_date)

    iznos_plus = input ("Iznos (n,nn): ")
#    logging.warning('%s | + | %s ..test' %(prihod_date, iznos_plus))
    
    valuta_plus = input ("\nValuta:\n1) kuna\n2) dolar\n3) euro\n")
    if valuta_plus=="1":
        valuta_plus = 'HRK'
    elif valuta_plus=="2":
        valuta_plus = 'USD'
    elif valuta_plus=="3":
        valuta_plus = 'EUR'
    else:
        input("\nNepodrzana valuta.\nPritisnit Enter za nastavak...")
        logging.warning('%s | + | %s !!(%s)!! | nepodrzana valuta.' %(prihod_date, iznos_plus, valuta_plus))
#    logging.warning('%s | + | %s (%s) | ..test' %(prihod_date, iznos_plus, valuta_plus))

    izvor_plus = input ("\nIzvor prihoda:\n1) Bankomat\n2) POINTER\n3) Ostalo\n")
    if izvor_plus=="1":
        izvor_plus = 'Bankomat'
        logging.info('%s | + | %s (%s) | %s ' %(prihod_date, iznos_plus, valuta_plus, izvor_plus))
    
    elif izvor_plus=="2":
        izvor_plus = 'POINTER'
        izvor_pointer = input ("\n1) Bonus\n2) Kompenzacija osobnih troskova\n3) Placa\n4) Prijevoz\n")
        if izvor_pointer=="1":
            izvor_pointer ='bonus'
        elif izvor_pointer=="2":
            izvor_pointer ='kompenzacija osobnih troskova'
        elif izvor_pointer=="3":
            izvor_pointer ='placa'
        elif izvor_pointer=="4":
            izvor_pointer ='prijevoz'
        else:
            izvor_pointer ='nije definirano.'
            pass
        logging.warning('%s | + | %s (%s) | %s !!! (%s) !!!' %(prihod_date, iznos_plus, valuta_plus, izvor_plus, izvor_pointer))
    
    elif izvor_plus=="3":
        izvor_plus = 'Ostalo'
        izvor_ostalo = input ("Info: ")
        logging.info('%s | + | %s (%s) | %s (%s)' %(prihod_date, iznos_plus, valuta_plus, izvor_plus, izvor_ostalo))
    
    else:
        izvor_plus = 'UNKNOWN'
        pass
        logging.warning('%s | + | %s (%s) | !!! %s !!!' %(prihod_date, iznos_plus, valuta_plus, izvor_plus))

else:
    prihod_date = time.strftime("%Y-%m-%d")
    iznos_plus = '0,00'
    valuta_plus = '---'
    logging.info('%s | + | %s (%s) | nema prihoda.' % (prihod_date, iznos_plus, valuta_plus))
    raise SystemExit("Nema prihoda. Izlazim.")

input ("\nUnos prihoda zavrsen. Pritisnite Enter za nastavak.")
logging.debug('End of application.')