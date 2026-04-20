# Управляемое движение
import pygame

pygame.init()

from pygame.color import THECOLORS

screenX = 900
screenY = 600

screen = pygame.display.set_mode([screenX, screenY])

xr = 400
yr = 200

width = 30
heigth = 150
step = 40  # Шаг ракетки. При каждом шаге ракетка перемещается на 10 пикселей

screenX1 = 900
screenY1 = 600

screen1 = pygame.display.set_mode([screenX1, screenY1])

xr1 = 450
yr1 = 250

width1 = 35
heigth1 = 155
step1 = 45

# Pакетка в начальном положении
pygame.draw.rect(screen, THECOLORS['brown'], [xr, yr, width, heigth], 0)
pygame.draw.rect(screen1, THECOLORS['red'], [xr1, yr1, width1, heigth1], 0)
running = True

while running:
    screen.fill(THECOLORS['white'])  # Стираем все изображения
    for event in pygame.event.get():  # Закрываем окно, если необходимо
        if event.type == pygame.QUIT:
            running = False
        elif event.type == pygame.KEYDOWN:  # тип события - нажатие клавиши

            if event.key == pygame.K_UP:  # Если вверх
                if (yr > step):  # движение возможно, если не вышли за верхнюю границу
                    # окна
                    yr = yr - step  # Перемещаемся на шаг вверх

            elif event.key == pygame.K_DOWN:
                if yr < screenY - step - heigth:
                    yr = yr + step  # И так далее


            elif event.key == pygame.K_LEFT:
                if xr > step:
                    xr = xr - step

            elif event.key == pygame.K_RIGHT:
                if xr < screenX - width - step:
                    xr = xr + step

            if event.key == pygame.K_w:  # Если вверх
                if (yr1 > step1):  # движение возможно, если не вышли за верхнюю границу
                    # окна
                    yr1 = yr1 - step1  # Перемещаемся на шаг вверх

            elif event.key == pygame.K_s:
                if yr1 < screenY1 - step1 - heigth1:
                    yr1 = yr1 + step1  # И так далее


            elif event.key == pygame.K_a:
                if xr1 > step:
                    xr1 = xr1 - step1

            elif event.key == pygame.K_d:
                if xr1 < screenX1 - width1 - step1:
                    xr1 = xr1 + step1

    pygame.draw.rect(screen, THECOLORS['brown'], [xr, yr, width, heigth], 0)
    pygame.draw.rect(screen1, THECOLORS['red'], [xr1, yr1, width1, heigth1], 0)
    pygame.display.flip()
pygame.quit()