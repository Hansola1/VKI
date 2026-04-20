import pygame
pygame.init()
from pygame.color import THECOLORS

#def zastavka_func():
    #width = 640
    #height = 480
    #screen = pygame.display.set_mode((width, height))

SCREEN_WIDTH = 800
SCREEN_HEIGHT = int(SCREEN_WIDTH * 0.8)

screen = pygame.display.set_mode([800, 600])
zastavka = 'zazastava.jpg'
pygame.display.update()
pygame.display.set_caption("zastavka")

screenX = 900
screenY = 600
screen = pygame.display.set_mode([screenX, screenY])

zastavka_file = "zazastava.jpg"
zastavka = pygame.image.load(zastavka_file)
screen.blit(zastavka, [0, 0])
pygame.display.flip()

running = True
while running:
    for event in pygame.event.get():  # Закрываем окно, если необходимо
         if event.type == pygame.QUIT:
            running = False
         elif event.type == pygame.KEYDOWN:  # тип события - нажатие клавиш
            if event.key:
                running = False
pygame.quit()