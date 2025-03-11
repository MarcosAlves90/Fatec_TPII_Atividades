import random, os

opcoes = {1: "pedra", 2: "papel", 3: "tesoura"}
score_humano = 0
score_maquina = 0
total_empates = 0
resultado_final = ""

def comparar_jogadas(jogada_humano, jogada_maquina, score_humano, score_maquina, total_empates):
    if jogada_humano == jogada_maquina:
        mensagem = "Empate"
        total_empates += 1
    elif jogada_maquina == 1:
        if jogada_humano == 2:
            mensagem = "Você venceu!"
            score_humano += 1
        else:
            mensagem = "A máquina venceu!"
            score_maquina += 1
    elif jogada_maquina == 2:
        if jogada_humano == 1:
            mensagem = "A máquina venceu!"
            score_maquina += 1
        else:
            mensagem = "Você venceu!"
            score_humano += 1
    elif jogada_maquina == 3:
        if jogada_humano == 1:
            mensagem = "Você venceu!"
            score_humano += 1
        else:
            mensagem = "A máquina venceu!"
            score_maquina += 1
    return mensagem, score_humano, score_maquina, total_empates

def obter_jogada_humano():
    jogada = input("Digite o seu ataque: ")
    while jogada != str(1) and jogada != str(2) and jogada != str(3):
        jogada = input("\nUtilize um dos valores válidos (1, 2 ou 3).\nDigite novamente: ")
    return int(jogada)

def jogar(score_humano, score_maquina, total_empates, resultado_final):
    for rodada in range(1, 11):
        os.system('cls')
        print(f"===== JO KEN PO =====\n[[ Rodada {rodada} de 10 ]]\n")
        print("[1] Pedra\n[2] Papel\n[3] Tesoura\n")
        jogada_humano = obter_jogada_humano()
        jogada_maquina = random.randint(1, 3)
        print(f'\nVocê jogou {opcoes[jogada_humano]}\nA máquina jogou {opcoes[jogada_maquina]}\n')
        resultado_final, score_humano, score_maquina, total_empates = comparar_jogadas(jogada_humano, jogada_maquina, score_humano, score_maquina, total_empates)
        print(f'{resultado_final}\nSeu score: {score_humano}\nScore da máquina: {score_maquina}\nEmpates: {total_empates}\n')
        input(f'[PRESSIONE ENTER PARA CONTINUAR]')
    return score_humano, score_maquina, total_empates, resultado_final

score_humano, score_maquina, total_empates, resultado_final = jogar(score_humano, score_maquina, total_empates, resultado_final)
while True:
    continuar = input("Quer continuar jogando? [S/N]: ")
    if continuar.upper() == "S":
        score_humano, score_maquina, total_empates, resultado_final = jogar(score_humano, score_maquina, total_empates, resultado_final)
    else:
        break