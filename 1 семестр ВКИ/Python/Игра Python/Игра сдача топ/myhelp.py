import pygame, sys
from pygame.color import THECOLORS
from pygame import font
pygame.init()

def myhelp():
    pygame.display.set_caption("Лунки и шары")
    screen = pygame.display.set_mode([900, 600])
    fon_file = "fon3.jpg"
    fon = pygame.image.load(fon_file)
    screen.blit(fon, [0, 0])

color = THECOLORS["white"]
top = 10
left = 20
font = pygame.font.Font(None, 30)

my_file = open("myhelp.txt", 'r', encoding='utf-8') # Открываем файл в режиме чтения
lines = my_file.readlines()  # Записываем строки из файла в список lines
my_file.readlines()  # прочитать все строки
my_file.close()


dlina = len(lines)
print (dlina)
fon_file = "fon3.jpg"
fon = pygame.image.load(fon_file)

screen = pygame.display.set_mode([900, 600])
screen.blit(fon,[0,0])

for i in range(0, dlina):
    #screen = pygame.display.set_mode([900, 600])

    ln = lines[i]
    dl = len(ln) - 1  # Удаляем символ конца строки
    ln = ln[0:dl]  # Копируем из исходной строки все, кроме символа конца строки

    text = font.render (ln, 1, color)
    screen.blit (text, [left, top])
    top = top + 30  # Следующая строка выводится ниже на 20 пикселей

    fon.blit(text, [150, 550])
    pygame.display.flip()

running=True
while running:
   for event in pygame.event.get():
        if event.type == pygame.KEYDOWN:
             running = False













