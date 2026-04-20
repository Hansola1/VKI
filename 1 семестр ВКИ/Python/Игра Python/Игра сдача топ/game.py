import pygame
import random

pygame.init()
from pygame.color import THECOLORS
import meny

# -----проверка взаимодействий-----------
def proverka(dx1, n, x1, y1, xrg, yrg, widthg, heigthg, r1, i, j, timer_minus_soccore):

    if (y1 >= (yrg - r1)) and (y1 <= (yrg + heigthg)) and (x1 >= (xrg - r1)) and (x1 < (xrg + widthg)):
        dx1 = -dx1
        if timer_minus_soccore != 0:
            timer_minus_soccore -= 1
        if i == j: #если i(шарик) равен j(лунки), то n(очков) увеличиваем
            n += 1
            j = random.randint(0, 6) #возращаем случайную лунку из 6
            print(i, j)
        elif i != j and timer_minus_soccore <= 0:
            n -= 2 # то уменьшаем n(очки)
            timer_minus_soccore = 100
    return i, j, n, dx1, timer_minus_soccore

# фон-----------------------------------------------
screenX = 900
screenY = 600
fon_file = "fon3.jpg"
fon = pygame.image.load(fon_file)
screen = pygame.display.set_mode([screenX, screenY])

pobeda_file = "pobeda.png"
pobeda = pygame.image.load(pobeda_file)
porashen_file = "porashenue.png"
porashen = pygame.image.load(porashen_file)

# -----счет-----------
score = 100
start_ticks = pygame.time.get_ticks()  # старт таймера

# герой-----------------------------------------------
geroy_file = "geroy.png"
geroy = pygame.image.load(geroy_file)
xrg = 400  # герой по X
yrg = 200  # герой по Y
widthg = 30  # ширина героя
heigthg = 150  # рост героя
stepg = 40  # шаг Героя
timer_minus_soccore = 0
N_lun = 7  # количество лунок на экране

screenX1 = 900
screenY1 = 600
screen1 = pygame.display.set_mode([screenX1, screenY1])
# герой-----------------------------------------------

# шрифт счета-----------------------------------------------
font = pygame.font.Font(None, 45)  # задаем шрифт

# шарик выгружалка-----------------------------------------------
sharuk1_file = 'sharuk1.png'
sharuk1 = pygame.image.load(sharuk1_file)

sharuk2_file = "sharuk2.png"
sharuk2 = pygame.image.load(sharuk2_file)

sharuk3_file = "sharuk3.png"
sharuk3 = pygame.image.load(sharuk3_file)

sharuk4_file = "sharuk4.png"
sharuk4 = pygame.image.load(sharuk4_file)

sharuk5_file = "sharuk5.png"
sharuk5 = pygame.image.load(sharuk5_file)

sharuk6_file = "sharuk6.png"
sharuk6 = pygame.image.load(sharuk6_file)

sharuk7_file = "sharuk7.png"
sharuk7 = pygame.image.load(sharuk7_file)

# шарик массив -----------------------------------------------
sharuk = []
sharuk.append(sharuk1)
sharuk.append(sharuk2)
sharuk.append(sharuk3)
sharuk.append(sharuk4)
sharuk.append(sharuk5)
sharuk.append(sharuk6)
sharuk.append(sharuk7)

color = []
for i in range(0, N_lun):
    color.append(i)

# лунки выгрузка-----------------------------------------------
lunka1_file = "lunka1.png"
lunka1 = pygame.image.load(lunka1_file)

lunka2_file = 'lunka2.png'
lunka2 = pygame.image.load(lunka2_file)

lunka3_file = "lunka3.png"
lunka3 = pygame.image.load(lunka3_file)

lunka4_file = "lunka4.png"
lunka4 = pygame.image.load(lunka4_file)

lunka5_file = "lunk5.png"
lunka5 = pygame.image.load(lunka5_file)

lunka6_file = "lunka6.png"
lunka6 = pygame.image.load(lunka6_file)

lunka7_file = "lunka7.png"
lunka7 = pygame.image.load(lunka7_file)

# массив луночный-----------------------------------------------
lunka = []
lunka.append(lunka1)
lunka.append(lunka2)
lunka.append(lunka3)
lunka.append(lunka4)
lunka.append(lunka5)
lunka.append(lunka6)
lunka.append(lunka7)

num_step = []  # движ лунок массив
num_col = []
x = []
y = []
dx0 = []  # движ лунок по х массив
dy0 = []
dx = []
dy = []
r = []
stepx = []  # шаги по х массив
stepy = []

for i in range(0, 7):
    num_step.append(0)
    num_col.append(50)
    x.append(random.randint(0, screenX - 15))
    y.append(random.randint(0, screenY - 20))
    dx0.append(2)  # движ лунок по горизонтали скорость
    dy0.append(2)
    dx.append(dx0[i] * (-2 + random.randint(0, 3)))
    dy.append(dy0[i] * (-2 + random.randint(0, 3)))
    r.append(20)
    stepx.append([-1, 0, 1]) #шаг х
    stepy.append([1, 0, -1])

# условия победы и поражение-------------------------------------
n_pobeda = 5
n_beda = 60
n_beda_shet = -10
seconds = 60  # кол-во времени на игру

# передвижение лунки------------------------------
i_sharuk = 0
n = 0 #очки

running = True
while running:
    if n > n_pobeda:  # условия для победы: если очков больше 5
        running = False
    screen.blit(fon, [0, 0])

    if seconds > n_beda or n < n_beda_shet:  # условие для поражения: 60 сек или -10 счёт
        running = False
    screen.blit(fon, [0, 0])


    for i in range(0, N_lun):
        num_step[i] += 1
        if num_step[i] == num_col[i]:
            num_step[i] = 0
            dx[i] = dx0[i] * (random.randint(-3, 3))
            dy[i] = dy0[i] * (random.randint(-3, 3))
            if (dx[i] != 0) and (dy[i] != 0):
                dx[i] = 0
        x[i] = x[i] + dx[i]  # новая x-координата
        y[i] = y[i] + dy[i]
# передвижение лунки------------------------------

# луночная проверка --------------------------------------------------
        if x[i] <= r[i]:
            dx[i] = abs(dx0[i] * (random.randint(-3, 3))) #abs() используется для возврата абсолютного значения числа
        elif x[i] >= screenX - r[i]:
            dx[i] = -abs(dx0[i] * (random.randint(-3, 3)))
        if y[i] <= r[i]:
            dy[i] = abs(dy0[i] * (random.randint(-3, 3)))
        elif y[i] >= screenY - r[i]:
            dy[i] = -abs(dy0[i] * (random.randint(-3, 3)))

        i, i_sharuk, n, dx[i], timer_minus_soccore = proverka(dx[i], n, x[i], y[i], xrg, yrg, widthg, heigthg, r[i], i,
                                                              i_sharuk, timer_minus_soccore)
# проверка столкновения лунок с героем

        screen.blit(lunka[i], [x[i], y[i]])  # для массива луноки отображалка по х и у

# управление героя---------------------------------------------
    for event in pygame.event.get(): #для события в списке событий
        if event.type == pygame.QUIT:
            running = False
        elif event.type == pygame.KEYDOWN:
            if event.key == pygame.K_UP:
                if yrg > stepg:  # движение возможно, если не вышли за верхнюю границу окна
                    yrg = yrg - stepg  # Перемещаемся на шаг вверх
            elif event.key == pygame.K_DOWN:
                if yrg < screenY - stepg - heigthg:  # движение возможно, если не вышли за нижнюю границу окна
                    yrg = yrg + stepg  # Перемещаемся на шаг вниз
            elif event.key == pygame.K_LEFT:
                if xrg > stepg:
                    xrg = xrg - stepg
            elif event.key == pygame.K_RIGHT:
                if xrg < screenX - widthg - stepg:
                    xrg = xrg + stepg

# таймер-----------------------------------------------
    seconds = (pygame.time.get_ticks() - start_ticks) / 1000  # скорость таймера
    text_time = font.render("Время: " + str(round(seconds)), 1, THECOLORS["white"])

# счет-----------------------------------------------
    text = font.render("Очки: " + str(n), 1, THECOLORS["white"])

# отображалка
    screen.blit(text, [40, 30])  # расположение текста очков
    screen.blit(text_time, [200, 30])  # расположение текста таймера
    screen.blit(geroy, [xrg, yrg]) # расположение героя
    screen.blit(sharuk[i_sharuk], [xrg - 10, yrg + heigthg // 3]) #отображалка шарика

# вывод-----------------------------------------------
    pygame.display.set_caption("zastavka")
    pygame.display.set_caption("meny")
    pygame.display.set_caption("myhelp")
    pygame.time.delay(10)
    pygame.display.flip()

# победа и поражение-----------------------------
if n > n_pobeda:
    running_pobeda = True
    running = False
    while running_pobeda:
        screen.blit(pobeda, [0, 0])
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running_pobeda = False
        pygame.time.delay(10)
        pygame.display.flip()

if seconds > n_beda or n < n_beda_shet:  # условие для поражения: 60 сек или -10 счёт
    running = True
    while running:  # пока цикл поражения
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
        screen.blit(porashen, [0, 0])

# победа и поражение-----------------------------
        pygame.time.delay(10)  # время задержки прогрузки
        pygame.display.flip()  # обновит содержание дисплея
pygame.quit()  # на выход
