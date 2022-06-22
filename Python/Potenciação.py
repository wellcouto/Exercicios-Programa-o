numero1 = int(input("Digite o número a ser potenciado: "))

pontencia = int(input("Digite a potência desejada: "))

while((pontencia < 0) or (numero1 <= 1)):
    print("Entrada inválida")
    numero1 = int(input("Digite o número a ser potenciado: "))
    pontencia = int(input("Digite a potência desejada: "))

potenciacao = 1
if pontencia > 0:
    for x in range(1, pontencia + 1):
        potenciacao = potenciacao * numero1

print()
print(numero1,"elevado a",pontencia, "é:",potenciacao)