def calculo():
    print('A media do aluno e: {}\nA Situacao Final: {}'.format(media,situacao))
while True:
    n1=float(input('Digite a nota 1 :'))
    n2=float(input('Digite a nota 2 :'))
    n3=float(input('Digite a nota 3 :'))
    media=round(((n1+n2+n3)/3),1)
    if media < 4:
        situacao='Reprovado'
    elif 4 <= media < 6:
        situacao='Recuperacao'
    else:
        situacao='Aprovado'
    calculo()
    confirma=input('Novo Calculo? [S/N] :')
    if confirma == 'n' or confirma == 'N':
        break