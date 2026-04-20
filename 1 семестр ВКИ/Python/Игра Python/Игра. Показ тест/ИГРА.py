import pygame, random
pygame.init()

# -----проверка взаимодействия движений-----------
def proverka(x, y, xr, yr, width, heigth):
    global dx, n
    if (y >= (yr - r)) and (y <= (yr + heigth)) and (x >= (xr - r)) and (x < (xr + width)):
        dx = -dx
# ------------------------------------------------

from pygame.color import THECOLORS

screenX = 900
screenY = 600
fon_file="fon.png"
fon=pygame.image.load(fon_file)
screen = pygame.display.set_mode([screenX, screenY])



geroy_file="geroy.png"
geroy=pygame.image.load(geroy_file)
xr = 400
yr = 200
width = 30
heigth = 150
step = 40  # шаг Героя

screenX1 = 900
screenY1 = 600
screen1 = pygame.display.set_mode([screenX1, screenY1])

#шаг лунок
num_step=0
num_col = 50
x=640
y=480
dx0=2
dy0=2
dx=-1
dy=0
r=20
stepx = [-1,0,1]
stepy = [1, 0, -1]

lunka1_file="lunka1.PNG"
lunka1=pygame.image.load(lunka1_file)


# Pакетка в начальном положении
pygame.draw.rect(screen, THECOLORS['brown'], [xr, yr, width, heigth], 0)
#pygame.draw.rect(screen1, THECOLORS['red'], [xr1, yr1, width1, heigth1], 0)
running = True

while running:
    screen.blit(fon, [0, 0])
    num_step += 1
    if num_step == num_col:
        num_step=0
        dx=dx0*(-2+random.randint(0,3))
        dy = dy0 * (-2 + random.randint(0, 3))
        if (dx!=0) and (dy!=0):
            dx=0
    x = x + dx  # новая x-координата круга
    y = y + dy  # новая y-координата круга

    #pygame.draw.circle(screen, THECOLORS['red'], [x, y], r, 0)

    if (x <= r) or (x >= screenX - r):
        dx = -dx  # отражение от вертикальной стенок
    if (y <= r) or (y >= screenY - r):
        dy = -dy  # отражение от горизонтальных стенок

    for event in pygame.event.get():  # Закрываем окно, если необходимо
        if event.type == pygame.QUIT:
            running = False
        elif event.type == pygame.KEYDOWN: # тип события - нажатие клавиши

            if event.key == pygame.K_UP:  # Если вверх
                if (yr > step):  # движение возможно, если не вышли за верхнюю границу
                    # окна
                    yr = yr - step  # Перемещаемся на шаг вверх

            elif event.key == pygame.K_DOWN:
                if yr < screenY - step - heigth:
                    yr = yr + step

            elif event.key == pygame.K_LEFT:
                if xr > step:
                    xr = xr - step

            elif event.key == pygame.K_RIGHT:
                if xr < screenX - width - step:
                    xr = xr + step


    def proverka(x, y, xr, yr, width, heigth):
        global dx, n
        if (y >= (yr - r)) and (y <= (yr + heigth)) and (x >= (xr - r)) and (x < (xr + width)):
            dx = -dx
    proverka(x, y, xr, yr, width, heigth)  # проверка столкновения
    screen.blit(geroy, [xr, yr])

    for i in range(0,12):
        screen.blit(lunka1, [x, y])
    pygame.time.delay(10)
    pygame.display.flip()

pygame.quit()
