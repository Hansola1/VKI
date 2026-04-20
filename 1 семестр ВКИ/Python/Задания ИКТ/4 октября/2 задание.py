import pygame
pygame.init()

from pygame.color import THECOLORS# импорт цветов

colors=["paleturquoise1","red","blue","green","yellow","magenta"]
#создали массив color из цветов

screen = pygame.display.set_mode([640,480])
screen.fill([187,255,255]) # fill screen with white

for i in range (6,0,-1):
    pygame.draw.circle(screen, THECOLORS[colors[i-1]],[320,240], i*20, 2)

    i = 0
    r = 0
    while r < 240:
        screen.fill([187, 255, 255])  # fill screen with color [187,255,255]
        r = 20 + i
        j = i % 6


        pygame.draw.circle(screen, THECOLORS[colors[1]], [320, 240], r, 2)
        pygame.time.delay(100)
        pygame.display.flip()
        i = i + 2

    while r > 30:
        i = i - 2
        r = 20 + i
        j = i % 6

        pygame.draw.circle(screen, THECOLORS[colors[1]], [320, 240], r, 2)
        pygame.time.delay(100)
        pygame.display.flip()
        screen.ful

pygame.display.flip()
running  = True
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False
pygame.quit()