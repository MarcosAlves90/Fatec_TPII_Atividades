import random, os

def operacao(numero1, numero2, operador):
    if operador == '+':
        return numero1 + numero2
    elif operador == '-':
        return numero1 - numero2
    else:
        return numero1 * numero2

acertos = 0

while True:
    os.system('cls')
    n1 = random.randint(1, 10)
    op = random.choice(["+", "-", "*"])
    n2 = random.randint(1, 10)
    resultado = operacao(n1, n2, op)
    print('Quantidade de Acertos:', acertos)
    print('Cálculo:')
    print(str(n1), op, str(n2))
    resp = int(input('Resultado: '))
    if resp == resultado:
        print('Acertou!!!')
        acertos += 1
    else:
        print('Errou.')
    confirma = input('Novo Cálculo [S/N]: ')
    if confirma.lower() == 'n':
        break