while True:
    try:
        valorVeiculo = float(input("Valor do veículo: "))
        valorEntrada = float(input("Valor de entrada: "))
        if valorEntrada > valorVeiculo:
            print("O valor de entrada não pode ser maior que o valor do veículo.")
            continue

        planoPagamento = int(input("Plano de pagamento:\n1 - 12 meses\n2 - 24 meses\n3 - 36 meses\n4 - 48 meses\n")) - 1
        if planoPagamento not in range(4):
            print("Opção inválida. Escolha entre 1 e 4.")
            continue

        mesesJuros = [[12, 12.8], [24, 24.5], [36, 32.4], [48, 41.7]]
        anoVeiculo = int(input("Ano do veículo: "))

        valorFinanciado = valorVeiculo - valorEntrada
        juros = mesesJuros[planoPagamento][1] / 100

        valorTotalComJuros = valorFinanciado * (1 + juros)
        valorParcela = valorTotalComJuros / mesesJuros[planoPagamento][0]

        ipva = valorVeiculo * 0.04 if anoVeiculo > 1995 else 0

        totalGlobal = valorTotalComJuros + ipva

        print("\nResumo da Operação:")
        print(f"Valor Financiado: R$ {valorFinanciado:.2f}")
        print(f"Plano de Pagamento Escolhido: {mesesJuros[planoPagamento][0]} meses - Juros de {mesesJuros[planoPagamento][1]}%")
        print(f"Valor da Parcela com Juros: R$ {valorParcela:.2f}")
        print(f"IPVA: R$ {ipva:.2f}")
        print(f"Total Global da Operação: R$ {totalGlobal:.2f}")
        break
    except ValueError:
        print("Por favor, insira valores numéricos válidos.")