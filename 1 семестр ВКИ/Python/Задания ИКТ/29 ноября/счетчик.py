if ochki==klad: # and tim>0:
            pygame.draw.rect(screen, [255,255,255], [450, 50, 100, 30], 0)
            text=font.render("Победа! Вы собрали все призы за " + str(timer-tim)+" сек",1, THECOLORS ["blue"])
            screen.blit(text,[450,50])
            tim=-1
            text = font.render("Press esc",1, THECOLORS["red"])
            screen.blit(text, [650, 250])
            pygame.time.delay(30)
            running = False
        ik,jk,font,ochki = drawlab(ochki)
        return(i,j,ik,jk,lab1,ochki,timer,tim)
    ik,jk,font,ochki = drawlab(ochki)
    i=ik
    j=jk
    running  = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            if event.type == pygame.KEYDOWN:
               i,j= analyskey(i,j,ik,jk)
               i,j,ik,jk,lab1,ochki,timer,tim = movelab(i,j,ik,jk,lab1,ochki,timer,tim)
            if event.type == pygame.USEREVENT:#Счет времени
                if tim>0:
                    tim=tim-1
                    pygame.draw.rect(screen, [255,255,255], [650, 250, 100, 30], 0)
                    text=font.render(str(tim),0, THECOLORS ["blue"])
                    screen.blit(text,[650,250])
                if tim==0 and ochki<klad:
                    pygame.draw.rect(screen, [255,255,255], [450, 50, 200, 30], 0)
                    text=font.render("Ваше время истекло",1, THECOLORS ["blue"])
                    screen.blit(text,[450,50])
                    pygame.display.flip()
                    text=font.render(str(tim),1, THECOLORS ["blue"])
                    screen.blit(text, [650, 250])
                    text = font.render("Press esc",1, THECOLORS["red"])
                    screen.blit(text, [650, 250])
                    pygame.time.delay(3000)
                    running=False
        pygame.display.flip()
    screen = pygame.display.set_mode([400, 600])
mylabirint()
pygame.quit()