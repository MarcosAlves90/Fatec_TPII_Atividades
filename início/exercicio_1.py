salarioMinimo = 1518
salario = float(input("Digite a quantidade de salarios: "))
salarioBruto = salarioMinimo * salario
inss = salarioBruto * 0.11 if salarioBruto >= 1850 else 0
salarioLiquido = salarioBruto - inss

print(f'\nSalario Bruto: {salarioBruto:.2f}\nINSS: {inss:.2f}\nSalario Liquido: {salarioLiquido:.2f}')