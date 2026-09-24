# КТ11 — Реализация и наследование интерфейсов
## Вариант 1. Геометрические фигуры

1. Определен базовый интерфейс `IShape` и расширяющий его `IDrawable`.
2. Реализованы классы `Circle` и `Rectangle` (только `IShape`), а также `Triangle` (`IDrawable`).
3. В `Program.cs` объекты обработаны в общем цикле `List<IShape>`.
4. Проверка и вызов дополнительных возможностей `Draw()` выполнены безопасно через сопоставление с шаблоном `is IDrawable drawable`.
<img width="1680" height="613" alt="изображение" src="https://github.com/user-attachments/assets/751875bb-649e-4004-93ae-351acbdcd7d9" />
Результаты работы:

<img width="532" height="452" alt="изображение" src="https://github.com/user-attachments/assets/3371577b-fe6e-4f74-a32c-b99383e46f04" />


