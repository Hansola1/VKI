import pygame
pygame.init()
from pygame.color import THECOLORS # Эта библиотека позволяет задавать цвета

screen = pygame.display.set_mode([640,480])

screen.fill([255,255,255]) # Белый экран

width = 255
height = 100
top = 100
left = 100
#pygame.draw.rect(screen, [left, top, width, height], 0)
pygame.draw.rect(screen, THECOLORS["blue"],[255,0,0],[0, 0, winsh, win_h/3], 0)
pygame.draw.rect(screen, THECOLORS["white"],[0,255,0],[0, win_h/3, winsh, win_h/3], 0)
pygame.draw.rect(screen, THECOLORS["red"],[0,0,255], [0, 2*win_h/3, winsh, win_h/3], 0)

pygame.display.flip()
running = True
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False
pygame.quit()
