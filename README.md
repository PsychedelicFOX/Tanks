Игра танки
Известная всем игра «Танчики», игровая логика может быть различна, но есть общие принципы. 
Игровое поле состоит из клеток, любой объект в игре может находить только в какой-то клетке 
(на 2-х клетках одновременно объект находиться не может). 
Объекты в игре – стены (пустое поле тоже можно рассматривать как объект), танки, снаряды, 
артефакты (придают какие-то новые возможности танкам).

Используемые классы (примерный перечень):
•	Under construction

Используемые паттерны (примерный перечень):
•	+-Стратегии для различного поведения танков, в том числе должна быть стратегия, управляемая с клавиатуры; (+)
•	+-Строитель для создания различных объектов танков, например, с разным оружием; (+)
•	Состояние для различных состояний танков («живой», «горит»); (+)
•	Адаптер – для танка с различными артефактами;
•	+Одиночка – для класса игры;
•	Итератор или посетитель для коллекции танков;
•	Цепочка обязанностей для обработки снаряда;
•	Хранитель для сохранения состояния игры;
•	и др.
