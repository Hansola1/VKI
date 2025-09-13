# Урок 2 - Знакомство со стеком React, Next.js, TanStack Query

## Установка 

Склонировать проект на диск С: в личную папку (на диске G: проект не развернется)

открыть в VSCode

В терминале VSCode выполнить:
```
Set-ExecutionPolicy -Scope CurrentUser RemoteSigned
```

Установка npm пакетов:

```
npm i
```


Запустить проект:

```
npm run dev
```

### Открыть в браузере две вкладки

http://localhost:3000/ - приложение

http://localhost:3000/api/groups - апи

### Открыть в VSCode

src/app/layout.tsx - точка входа

src/api/groupsApi.ts - обращение к API

src/app/groups/route.ts - API возвращает список групп

### Задача 1 - реализация GET запроса

src/api/groupsApi.ts - обращение к API

```
  /* TODO: groupsApi должен возвращать данные через апи,
    не должно быть обращение в БД напрямую
  */
  const groups = getGroupsDb();

  /* TODO: реализовать получение данных через апи
   http://localhost:3000/api/groups используя fetch
   */
```

### Задача 2

Добавить страницу groups по аналогии с главной

Добавить страницу students по аналогии с groups, добавить ссылку в меню

### Задача 3

Добавить api/students по аналогии с api/groups

## Ссылки

- [Next.js Documentation](https://nextjs.org/docs) - learn about Next.js features and API.
  
- [Learn Next.js](https://nextjs.org/learn) - an interactive Next.js tutorial.

- TanStackQuery - https://tanstack.com/query/latest

- https://nextjs.org/docs/app/api-reference/file-conventions/route

