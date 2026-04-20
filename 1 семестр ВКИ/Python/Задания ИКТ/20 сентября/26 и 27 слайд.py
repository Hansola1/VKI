import pygame
pygame.init()
from pygame.color import THECOLORS
colors=["red","blue","green","yellow","magenta"]
screen = pygame.display.set_mode([640,480])
screen.fill([255,255,255]) # fill screen with white
for i in range (5,0,-1):
    pygame.draw.circle(screen, THECOLORS[colors[i-1]],[320,240], i*20, 0)
pygame.display.flip()
running  = True
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT: 
            running = False
pygame.quit()
