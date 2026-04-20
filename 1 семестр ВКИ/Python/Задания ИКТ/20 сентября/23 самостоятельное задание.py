import pygame
pygame.init()
from pygame.color import THECOLORS
colors=["red","blue","green","yellow","magenta"]
screen = pygame.display.set_mode([640,480])
screen.fill([255,255,255]) # Белый экран
for i in range (1,6):
    pygame.draw.circle(screen, THECOLORS[colors[i-1]],[320+i*20,240], i*20, 2)
pygame.display.flip()

running  = True
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT: 
            running = False
pygame.quit()
