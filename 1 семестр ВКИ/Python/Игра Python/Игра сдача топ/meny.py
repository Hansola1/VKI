import pygame
import sys
from pygame.color import THECOLORS
from pygame import font
import zastavka

# import myhelp
pygame.init()

# running=True
# while running:
# Zastavka.zastavka1()
# for event in pygame.event.get():
# if event.type == pygame.KEYDOWN:
# running = False

pygame.display.set_caption("Лунки и шары")

# положение элементов------------------------
screen = pygame.display.set_mode([900, 600])
fon = pygame.Surface(screen.get_size())
top = [50, 200, 360, 500] # расположение элементов текса,

left = 330 # от левой границы экрана
width = 200  # ширина элемента кнопки
height = 80 # высота элемента кнопки
# положение элементов------------------------


# значки и фон
menu_text = [" Играть", "Правила", " Выйти"]
color = THECOLORS["green"] # цвет элемента кнопки

fon_file = "fon1.jpg"
fon = pygame.image.load(fon_file)
screen.blit(fon, [0, 0])

font = pygame.font.Font(None, 55)
line_width = 0

running = True
while running:
    for i in range(0, 3):
        pygame.draw.rect(fon, color, [left, top[i], width, height], line_width)
        text = font.render(menu_text[i], 1, THECOLORS["white"])
        fon.blit(text, [left + 25, top[i] + 25])
    text = font.render(" ", 1, THECOLORS["white"])

    fon.blit(text, [150, 10])
    screen.blit(fon, (0, 0))
    pygame.display.flip()

    # кнопочки
    for event in pygame.event.get():
        if event.type == pygame.MOUSEBUTTONDOWN:
            (x, y) = pygame.mouse.get_pos()
            for i in range(0, 3):
                if x > left and x < left + width and y > top[i] and y < top[i] + height:
                    break # если располагается тут и тут и тут...
            if i == 2:
                running = False
            if i == 0:
                import game

                game.pygame()
            if i == 1:
                import myhelp

                myhelp.myhelp()
pygame.quit()
