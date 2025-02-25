lista = []
for i in range(5):
    num = int(input(f'Digite o {i} numero: '))
    lista.append(num)
print(f'Maior: {max(lista)}\nMenor: {min(lista)}')