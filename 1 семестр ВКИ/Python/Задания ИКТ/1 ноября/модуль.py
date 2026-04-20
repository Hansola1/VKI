import pygame
pygame.init()
import ModMas

# -----проверка взаимодействия движений-----------

def proverka(dy, n, x, y, xr, yr, width, heigth):
    if (y >= (yr - r)) and (y <= (yr + heigth)) and (x >= (xr - r)) and (x < (xr + width)):
        dy = -dy
        n = n + 1
    return n, dy

# -----------------------------------------

screenX=900
screenY=600

screen = pygame.display.set_mode([screenX,screenY])

screen.fill(THECOLORS['white'])#заливка белым экрана

# ----------------------------------------------------

from pygame.color import THECOLORS

x=[]
y=[]

dx=[]
dy=[]
r=20

n=7

for i in range(0,n):
    x.append(50*(i+1))
    y.append(50*(i+1))
    dx.append(2)
    dy.append(2)

#ffffffffffffffffffffffffffffffffffffffffffffffff

screen = pygame.display.set_mode([screenX, screenY])

xr = 400
yr = 200
n = 0
width=150
heigth=10
step=50 #Шаг ракетки. При каждом шаге ракетка перемещается на 10 пикселей


screenX1 = 900
screenY1 = 600

screen1 = pygame.display.set_mode([screenX1, screenY1])

xr1 = 450
yr1 = 250

width1 = 35
heigth1 = 155
step1 = 45

x=640
y=480

dx=2
dy=2
r=20
pygame.draw.circle(screen, THECOLORS['red'],[x,y], r, 0)

# Pакетка в начальном положении
pygame.draw.rect(screen, THECOLORS['brown'], [xr, yr, width, heigth], 0)
pygame.draw.rect(screen1, THECOLORS['red'], [xr1, yr1, width1, heigth1], 0)

running = True

while running:
    screen.fill(THECOLORS['white'])
    for i in range(0, n):
        x[i], y[i], dx[i], dy[i] = ModMas.neupr(x[i], y[i], dx[i], dy[i], r, screen, screenX1, screenY1)


#ffffffffffffffffffffffffffffffffffffffffffff

    pygame.draw.circle(screen, THECOLORS['red'], [x, y], r, 0)

    if (x <= r) or (x >= screenX - r):
        dx = -dx  # отражение от вертикальной стенок
    if (y <= r) or (y >= screenY - r):
        dy = -dy  # отражение от горизонтальных стенок

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

    for i in range(0,n):
        n, dy[i]=proverka(dy[i],n,x[i],y[i],xr,yr,width,heigth)

    #def proverka(x, y, xr, yr, width, heigth):
        #global dx, n

        if (y >= (yr - r)) and (y <= (yr + heigth)) and (x >= (xr - r)) and (x < (xr + width)):
            dx = -dx
    proverka(x, y, xr, yr, width, heigth)  # проверка столкновения
    proverka(x, y, xr1, yr1, width, heigth)  # проверка столкновения

    for i in range(0,n):
        n, dy[i]=proverka(dy[i],n,x[i],y[i],xr,yr,width,heigth)
    pygame.draw.rect(screen, THECOLORS['brown'], [xr, yr, width, heigth], 0)
    pygame.draw.rect(screen1, THECOLORS['red'], [xr1, yr1, width1, heigth1], 0)
    pygame.draw.circle(screen, THECOLORS['red'], [x, y], r, 0)
    pygame.time.delay(10)
    pygame.display.flip()
pygame.quit()