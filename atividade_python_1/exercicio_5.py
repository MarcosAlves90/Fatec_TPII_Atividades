import random, os

opcoes = {1: "pedra", 2: "papel", 3: "tesoura"}
scoreH = 0
scoreM = 0
empate = 0
result = ""

def comparador(humano, maquina, hum_score, maq_score, empate_score):
    if humano == maquina:
        msg = "empate"
        empate_score += 1
    elif maquina == 1:
        if humano == 2:
            msg = "Você venceu!"
            hum_score += 1
        else:
            msg = "A máquina venceu!"
            maq_score += 1
    elif maquina == 2:
        if humano == 1:
            msg = "A máquina venceu!"
            maq_score += 1
        else:
            msg = "Você venceu!"
            hum_score += 1
    elif maquina == 3:
        if humano == 1:
            msg = "Você venceu!"
            hum_score += 1
        else:
            msg = "A máquina venceu!"
            maq_score += 1
    return msg, hum_score, maq_score, empate_score

def jogada_humano():
    jogada = input("Digite o seu ataque: ")
    while jogada != str(1) and jogada != str(2) and jogada != str(3):
        jogada = input("\nUtilize um dos valores válidos (1, 2  ou 3).\nDigite novamente: ")
    return int(jogada)

def jogar(pontua_hum, pontua_maq, ponto_empate, resultado):
    for x in range(1, 11):
        os.system('cls')
        print(f"----- JO KEN PO -----\n>>> Rodada {x} de 10 <<<")
        print("[1] Pedra\n[2] Papel\n[3] Tesoura\n")
        jogada_h = jogada_humano()
        jogada_m = random.randint(1, 3)
        print(f'\nVocê jogou {opcoes[jogada_h]}\nA máquina jogou {opcoes[jogada_m]}\n')
        resultado, pontua_hum, pontua_maq, ponto_empate = comparador(jogada_h, jogada_m, pontua_hum, pontua_maq, ponto_empate)
        print(f'{resultado}\nSeu score: {pontua_hum}\nScore da máquina: {pontua_maq}\nEmpates: {ponto_empate}\n')
        input(f'[PRESSIONE ENTER PARA CONTINUAR]')
    return pontua_hum, pontua_maq, ponto_empate, resultado

scoreH, scoreM, empate, result = jogar(scoreH, scoreM, empate, result)
while True:
    continuar = input("Quer continuar jogando? [S/N]: ")
    if continuar.upper() == "S":
        scoreH, scoreM, empate, result = jogar(scoreH, scoreM, empate, result)
    else:
        break