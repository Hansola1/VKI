import pygame
pygame.init()
from pygame.color import THECOLORS

def neupr(x,y, dx,dy,r, screen, screenX, screenY):
x = x + dx  # новая x-координата круга
y = y + dy  # новая y-координата круга

pygame.draw.circle(screen, THECOLORS['red'], [x, y], r, 0)
if (x <= r) or (x >= screenX - r):
    dx = -dx  # отражение от вертикальной стенок
if (y <= r) or (y >= screenY - r):
    dy = -dy  # отражение от горизонтальных стенок
return x, y, dx, dy
