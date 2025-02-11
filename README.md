## Подготовка

1. **Установка Git:**  
   Скачай и установи [Git для Windows](https://git-scm.com/download/win), если он ещё не установлен.

2. **Аккаунт на GitHub:**  
   Зарегистрируйся на [GitHub](https://github.com/), если у тебя его ещё нет.

---

## Клонирование репозитория

Открой Git Bash или терминал и выполни команду:

```bash
git clone https://github.com/f0tt3r/ZurkScripts.git
```

Эта команда создаст локальную копию репозитория на твоём компьютере.

##Работа с репозиторием

1. Создай новую ветку для своей задачи:

```bash
git checkout -b имя_ветки
```

2. Воси изменения:
Редактируй файлы в удобном тебе редакторе.

3. Сохраняй изменения:

```bash
git add .
git commit -m "Описание внесённых изменений"
```
4. Отправь изменения на GitHub:

```bash
git push origin имя_ветки
```

## Создание Pull Request

После отправки изменений зайди на страницу репозитория на GitHub и создай Pull Request из своей ветки в основную ветку (main или master). 
Это позволит обсудить и интегрировать твои изменения в проект.

