import pygame
    
sd.resolution = (1200, 600)
    
rainbow_colors = (sd.COLOR_RED, sd.COLOR_ORANGE, sd.COLOR_YELLOW, sd.COLOR_GREEN,
                      sd.COLOR_CYAN, sd.COLOR_BLUE, sd.COLOR_PURPLE)
start_point = sd.get_point(50, 50)
end_point = sd.get_point(350, 450)
step_x = 5
step_y = 5
    
for _ in range(7):
    
