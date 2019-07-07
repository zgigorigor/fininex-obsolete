#trosak = input('Zelis upisati trosak? ')
#if trosak=="da":
#    os.system('python C:/Software/dev/fininex/troskovi.py')
#    logging.debug('troskovi.py executed')
#    while True:
#        dod_trosak = input('Jos racuna? ')
#        if dod_trosak=="da":
#            os.system('python C:/Software/dev/fininex/troskovi.py')
#            logging.debug('troskovi.py executed')
#        else:
#            #trosak_total =
#            logging.warning('gotov unos troskova.')
#            break
#else:
#    #trosak = '0,00'
#    logging.warning('%s | - | %s (%s) | x | nema troskova.' % (date, iznos, valuta))

#while True:
#    trosak = input("Zelis upisati trosak? ")
#        if trosak=="da":
#            trosak_iznos = input("Iznos kupovine (n,nn): ")
#            trosak_valuta =" kn"
#        else:
#            input("\nZavrsen unos troskova. Pritisni Enter za nastavak... ")
#            break
#    print('Trosak: iznos: %s (%s)' % (trosak_iznos, trosak_valuta))
total = 0
while True:
    trosak = input("Zelis upisati trosak? ")
    if trosak=="da":
        izn = input("Unesi iznos: ")
        total += float(izn)
    else:
        print("gotovo. %s" %total)
        break
input("\nZavrsen unos troskova. Pritisni Enter za nastavak... ")
