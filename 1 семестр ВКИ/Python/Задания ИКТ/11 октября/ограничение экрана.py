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

# Pакетка в начальном положении
pygame.draw.rect(screen, THECOLORS['brown'], [xr, yr, width, heigth], 0)
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


    pygame.draw.rect(screen, THECOLORS['brown'], [xr, yr, width, heigth], 0)
    pygame.display.flip()
pygame.quit()