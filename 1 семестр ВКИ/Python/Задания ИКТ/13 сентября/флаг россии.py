import pygame
pygame.init()
winsh = 640
win_h = 480

screen = pygame.display.set_mode([winsh,win_h])
screen.fill([255, 255, 255])#белый экран
#Размеры и положение прямоугольника

# рисуем прямоугольник
pygame.draw.rect(screen, [255,0,0], [0, 0, winsh, win_h/3], 0)
pygame.draw.rect(screen, [0,60,0], [0, win_h/3, winsh, win_h/3], 0)
pygame.draw.rect(screen, [0,0,90], [0, 2*win_h/3, winsh, win_h/3], 0)
#screen - на чем рисуем
#[255,0,0] - цвет RGB, red
#[left, top, width, height]- координаты левого верхнего угла, длина ширина
# 0 - сплошная заливка, 1,2 и т.д - ширина линии контура, заливка отсутствует
pygame.display.flip()# Вывод изображения в графическое окно
running = True
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False
pygame.quit()
