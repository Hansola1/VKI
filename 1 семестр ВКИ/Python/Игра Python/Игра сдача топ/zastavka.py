import pygame
pygame.init()
from pygame.color import THECOLORS
from pygame import font

def zastavka():
    width = 900
    height = 600
    screen = pygame.display.set_mode((width, height))

# заставка---------------------------------------------------------------------
screen = pygame.display.set_mode([900, 600])
zastavka_file = "zazastava.jpg"
zastavka = pygame.image.load(zastavka_file)
pygame.display.update()
pygame.display.set_caption("zastavka")
screen.blit(zastavka, [0, 0])

pygame.display.flip() #вызываем, чтобы сделать видимыми обновлений экрана

running = True
while running:
    for event in pygame.event.get():
         if event.type == pygame.QUIT:
            running = False
         elif event.type == pygame.KEYDOWN:
            if event.key:
                running = False
# заставка---------------------------------------------------------------------
pygame.quit()