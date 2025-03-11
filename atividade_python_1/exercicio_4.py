import random, os

def jogar_novamente(numero):
    print(f'O número era: {numero}')
    confirma = input('Novo Cálculo [S/N]: ')
    if confirma.lower() == 'n':
        return False, numero, 0
    else:
        numero = random.randint(1, 50)
        tentativa = 5
        os.system('cls')
        return True, numero, tentativa

def main():
    num = random.randint(1, 50)
    tentativa = 5
    jogar = True


    while jogar:
        os.system('cls')
        if tentativa < 1:
            print("Você perdeu.")
            jogar, num, tentativa = jogar_novamente(num)
            continue
        print('Adivinhe o número')
        print('Tentativas:', tentativa)
        palpite = int(input('Digite seu palpite: '))

        if palpite != num:
            input(f'\nDigite um número {"maior" if palpite < num else "menor"} [PRESSIONE ENTER]')
            tentativa -= 1
        else:
            os.system('cls')
            print('Você ganhou!!!')
            jogar, num, tentativa = jogar_novamente(num)

main()