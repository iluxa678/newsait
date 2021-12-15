# Система ветпомощи нуждающимся
## Содержание
[Введение](#intro)  
[1 Описание предметной области](#description)  

[2 Сравнительный анализ существующих программных решений ](#analysis)

[3 Разработка системы](#design)

[4 Проверка качества](#check)

[Список использованных источников](#litr)

<a name="intro"/>
 
## Введение

В городах Российской Федерации проживает около 75% населения. Большинство содержат в домашних условиях собак, кошек, птиц, рептилий и т.д. В частных секторах ещё и сельскохозяйственных животных, таких как коровы, лошади, сельскохозяйственная птица, а так же малый рогатый скот.

В пригородах находится множество промышленных перерабатывающих предприятий, ферм и агрокомплексов, на которые поступают продукты, сырье и животные. На рынки поступают продукция животноводства и растениеводства из разных районов страны.

Ветеринарные учреждения, такие как частные вет. клиники, СББЖ(станция по борьбе с болезнями животных), ветеринарные кабинеты, ветеринарные лаборатории и лаборатории ветсанэкспертизы призваны охранять животноводство от заноса опасных болезней, охранять города и населения от зооантропонозов(группы инфекционных и инвазионных болезней, общих для животных и человека), обеспечивать безопасность продукции, поставляемой на прилавки, а так же обеспечить здоровое мирное сосуществование домашних питомцев с их хозяевами.
 
<a name="description"/>
 
## 1 Описание предметной области
 
Число пациентов в ветеринарных клиниках с каждым годом только увеличивается. В результате, в последнее время ветеринары все чаще сталкиваются с такими заболеваниями, которые раньше практически не встречались. Таким образом, постепенно расширяется спектр услуг. Повышается статус ветеринарного врача. В частном сегменте рынка ветеринарных услуг наблюдаются прогрессивные тенденции. Появляется значительное количество частных ветеринарных клиник и лабораторий, предоставляющих платные лечебные и диагностические услуги.

Консультации и приемы в вет. клиниках ведут одновременно несколько ветеринарных врачей разных специальностей, таких как врач-диетотог(это врач, который занимается вопросами безопасного, физиологически сбалансированного питания для здоровых пациентов и лечебного — для больных) и врач-терапевт(это специалист широкого профиля, в его компетенции находятся вопросы ранней диагностики и лечения многих заболеваний), выполняющих диагностику животных с последующей разработкой плана питания или плана лечения, в зависимости от специфики проблемы. Регистратура является центральным, связующим звеном в работе всей клиники и координирует работу ветспециалистов. 

Современная ветеринарная клиника – это сложная организационная структура, и от участия каждого сотрудника зависит стабильность работы лечебного учреждения. Это скрытая часть айсберга, которую не должен явно замечать обратившийся в ветеринарную клинику владелец больного животного. Темп жизни современного человека заставляет его прикладывать максимальные усилия для анализа и учета информации, а сложнее всего это делать при ее непрерывном потоке, с чем и сталкиваются руководство и сотрудники многих клиник, особенно отдела регистратуры. Эффективность функционирования предприятия или организации любой отрасли и сферы деятельности напрямую зависит от скорости, точности и своевременности обмена данными как внутри этого предприятия между его составляющими частями, так и вне его, то есть взаимодействие и обмен данными этой организации с клиентами. 

Для качественного решения подобных проблем на предприятиях используются автоматизированные системы управления (АСУ). Автоматизированная система управления – это человеко-машинная система, обеспечивающая автоматизированный сбор и обработку информации, необходимой для оптимизации управления в различных сферах человеческой деятельности. 
Актуальность данной работы заключается в необходимости комплексной автоматизации всех подразделений ветеринарной клиники. Целью является разработка и воплощение системы автоматизации ветеринарной клиники, позволяющей увеличить производительность труда всех сотрудников, повысить качество, скорость и своевременность обслуживания клиентов и усилить контроль над всеми этапами трудовой деятельности специалистов клиники. 

<a name="analysis"/>
 
## 2 Сравнительный анализ существующих программных решений
Для сравнения были рассмотренны 4 системы автоматизации ветеринарно клиники:

Первая система - Ветменеджер.

Ветменеджер - это онлайн сервис для ветеринарных клиник, который позволяет вести медицинские карты животных-пациентов (в которые можно заносить записи, результаты опросов, рентген снимки, УЗИ, фотографии и видео, сканированные документы), планировать приемы ветеринаров, отправлять SMS и E-mail рассылки клиентам, вести учет товаров и материалов на складе и др. Есть возможность работы с программой на мобильных устройствах Android и iOS. 

Вторая система - VetDesk.

VetDesk - это приложение, полностью автоматизирующее документооборот небольшой ветеринарной клиники. Функционал включает в себя ведение карточек животных-пациентов, учет приемов, печать документов, отправка напоминаний пользователю.


Третья система - Ветсофт-Ветеринар.

Ветсофт-Ветеринар - это программный комплекс для ветеринарных клиник. Реализованный функционал – ведение электронных историй болезни, автоматизация ветеринарной аптеки, складской учет на основании документооборота, электронное расписание врачей и запись клиентов на прием, удобная работа с принтерами, работа со сканерами штрих кодов, учет бонусов, создание шаблонов документов и рекомендаций, гибкая система отчетов, а также конструктор документов.

Учет ведется в разрезе каждой отдельной клиники с общей базой по клиентам и животным. Система не требует постоянного интернет соединения. Комплекс содержит гибкие и настраиваемые системы напоминаний и контроля. Отправка документов, счетов, актов выполненных работ непосредственно из комплекса на E-mail. Реализован юридический учет договоров, дополнительных соглашений, информированных согласий и т.п. Также весь документооборот по истории болезни собирается во внутреннем редакторе системы. Реализован ряд дополнительного и полезного функционала - автоматизация деятельности клинической лаборатории, информационная электронная очередь, финансовый учет деятельности клиник и т.д.

Четвертая система - Андиаг.

Андиаг - удобная программа, которая упорядочивает ветеринарную деятельность. Включается в себя ветеринарную энциклопедию, ветеринарный атлас, систему компьютерно ассистированной диагностики (КАД) – энциклопедически базированный метод быстрой дифференциальной диагностики.

Сравнивая существующие программные решения с "Системой ветпомощи нуждающимся", можно выделить явное преимущество последней. "Система ветпомощи нуждающимся" включает в себя  круглосуточную онлайн помощь от опытных врачей, что позволяет клиентам получать квалифицированную помощь в любое время, в любом месте.

<a name="design"/>

## 3 Разработка системы

<В процессе проектирования системы, изначально была разработанна диаграмма вариантов использования. В результате анализа предметной области было определено 4 сущности: клиент, оператор, вет. диетолог и вет. врач. 

Рассмотрим функции каждой из сущностей.
Сущность-Клиент может подавать обращение в организацию, в процессе заполняя сведения о животном, и получать ответ на свое обращение от организации.
Сущность-Оператор может принимать обращение от клиента, в процессе выбирая специалиста, который будет решать проблему, описанную в обращении. Так же сущность-Оператор может получать заключения от специалистов и следовательно оповещать о результатах клиента.
Сущность-Вет. диетолог может рассматривать обращение, составлять по нему заключение, в процессе составляя план питания.
Сущность-Вет. врач, так же как и Вет. диетолог рассматривает обращение, составляет по нему заключение, но только составляя уже план лечения.

<p align="center">
<img src=https://user-images.githubusercontent.com/91088733/144324826-84dbae52-c5ce-441f-8bb2-9f63b6870ab1.png>
<p align="center">Рисунок 1 - Диаграмма вариантов использования</p>  

***

<Далее была разработанна диаграмма потоков данных. В результате анализа предметной области были определены основные сущности данных и действия, требующие взаимодействия с этими сущностями.

Рассмотрим действия, относящиеся к Клиенту. 
При регистрации клиент вносит свои данные в сущность 'клиент', а при авторизации наоборот, из сущности 'клиент' берутся данные о клиенте. После входа в меню перед пользователем открывается несколько путей. 
Первый - добавление животного, при этом данные о животном заносятся в сущность 'животное'. 
Второй - просмотр обращения, при этом данные подтягиваются из сущности 'обращение'. Третий - составление обращение с последующим выбором животного, данные о котором подтягиваются из сущности 'животное', добавлением проблемы, добавлением продолжительности болезни, добавления примечаний. В итоге все эти данные заносятся в сущность 'обращение'. 
Четвертый - просмотр заключения, при этом данные подтягиваются из сущности 'заключение'.

Рассмотрим действия, относящиеся к Оператору.
Перед оператором стоят несколько задач, связанных с обработкой обращений и обновлений врачебных данных.
Первая - модерация обращения, при этом данные подтягиваются из сущности 'обращение'. При модерации оператор меняет статус обращения с 'отправлено' на 'прошло модерирование'(статусы подтягиваются из сущности 'статусы обращения'), новые данные заносятся в сущность 'обращение'. Вторая - заполнение списка диагнозов, заболеваний, симптоматики, рекомендаций, методов лечения, услуг врачей, статусов обращения, которые подтягиваются и заносятся в соответствующие сущности.

Рассмотрим действия, относящиеся к вет. врачу. Перед вет. врачём стоят несколько задач, связанных с рассмотрением обращений и составлением заключений.
Первая - рассмотрение обращения, при этом данные подтягиваются из сущности 'обращение'. При рассмотрении, вет. врач меняет статус обращения с 'прошло модерацию' на 'рассмотрено'(статусы подтягиваются из сущности 'статусы обращения'), новые данные заносятся в сущность 'обращение'. Вторая - составление заключения, при котором вет. врач решает, кому из врачей передается решение проблемы. Если же это компетенция самого вет. врача, то выбирается предоставляемая услуга, подтягивающаяся из сущности 'список услуг', добавляется заболевание, подтягивающееся из сущности 'заболевания', и конечные данные заносятся в сущность 'заключение'.

Действия вет. диетолога подобны действиям вет.врача. Если же вет. врач решает, что решение проблемы передаётся вет. диетологу, то уже тот в свою очередь выбирает предоставляемую услугу, подтягиваемую из сущности 'список услуг', добавляет заболевание, подтягиваемое из сущности 'заболевания', и конечные данные заносятся в сущность 'заключение'.

<p align="center">
<img src=https://user-images.githubusercontent.com/91088733/144330038-89b8d92a-720e-42f7-94e3-aff8a5d954e8.png>
<p align="center">Рисунок 2 - Диаграмма потоков данных</p>  

***

<Последняя разработанная диаграмма - это диаграмма отношений. В результате анализа предметной области были выявлены следующие сущности: вид, порода, и пол животного, клиент, животное, статус обращения, обращение, заключение, доктор, должность и услуга доктора, симптоматика заболевания, заболевание, симптомы, рекомендации, метод лечения, и диагноз.

Сущность 'вид животного' характеризуется такими атрибутами, как: номер вида и наименование вида.

Сущность 'порода животного' характеризуется такими атрибутами, как: номер породы и наименование породы.

Сущность 'пол животного' характеризуется такими атрибутами, как: номер пола и наименование пола.

Сущность 'клиент' характеризуется такими атрибутами, как: номер клиента и ФИО клиента.

Сущность 'животное' характеризуется такими атрибутами, как: номер животного, сущность 'вид животного', сущность 'порода животного', сущность 'пол животного', кличка, возраст, вес, расцветка.

Сущность 'статус обращения' характеризуется такими атрибутами, как: номер статуса и наименование статуса.

Сущность 'обращение' характеризуется такими атрибутами, как: номер обращения, дата обращения, сущность 'клиент', сущность 'животное', примечания, описание, продолжительность болезни, сущность 'статус'.

Сущность 'заключение' характеризуется такими атрибутами, как: номер заключения, дата заключения, сущность 'обращение', сущность 'доктор', сущность 'заболевание'. 

Сущность 'доктор' характеризуется такими атрибутами, как: номер доктора, ФИО доктора, сущность 'должность', опыт работы. 

Сущность 'должность' характеризуется такими атрибутами, как: номер должности, наименование должности, сущность 'услуга'.

Сущность 'услуга' характеризуется такими атрибутами, как: номер услуги, наименование услуги, описание услуги.

Сущность 'симптоматика заболевания' характеризуется такими атрибутами, как: номер симптоматики заболевания, сущность 'симптомы', сущность 'заболевание'.

Сущность 'заболевание' характеризуется такими атрибутами, как: номер заболевания, наименование заболевания, описание заболевания, сущность 'диагноз'. 

Сущность 'симптомы' характеризуется такими атрибутами, как: номер симптомов, наименование симптомов, описание симптомов. 

Сущность 'рекомендации' характеризуется такими атрибутами, как: номер рекомендации, описание рекомендации, сущность 'диагноз', сущность 'заболевание'. 

Сущность 'метод лечения' характеризуется такими атрибутами, как: номер метода, описание метода, сущность 'заболевание', сущность 'диагноз'. 

Сущность 'диагноз' характеризуется такими атрибутами, как: номер диагноза, наименование диагноза, описание диагноза. 

<p align="center">
<img src=https://user-images.githubusercontent.com/91088733/146170346-e3f09769-39ac-40a9-aea7-50228558e348.png>
<p align="center">Рисунок 3 - Диаграмма отношений</p>  

***

По представленным диаграммам были разработанны классы: 'вид животного', 'порода животного', 'пол животного', 'клиент', 'животное', 'статус обращения', 'обращение', 'заключение', 'доктор', 'должность', 'услуга', 'симптоматика заболевания', 'заболевание', 'симптомы', 'рекомендации', 'метод лечения' и 'диагноз'.

Примеры кода нескольких классов:

Класс "Обращение":

```csharp
namespace newsait.Domains
{
        public class Appeal
        {
        public int AppealId { get; set; }
        public DateTime DateAppeal { get; set; }
        public Client Client { get; set; }
        public Pet Pet { get; set; }
        public string Notes { get; set; }
        public string Description { get; set; }
        public int Lasting { get; set; }
        public Status Status { get; set; }
    }  
}
```

Класс "Клиент":

```csharp
namespace newsait.Domains
{
        public class Client
        {
            public int ClientId { get; set; }
            public string ClientName { get; set; }           
        }  
}
```

***

Так же по представленным диаграммам был разработан репозиторий - то, что позволяет создавать, хранить, актуализировать и использовать информацию в системе. Эти возможности предоставленны для вышеуказанных классов.

Примеры кода Хранилищь:

Хранилище Обращения:

```csharp
using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class AppealStorage
    {
        private Dictionary<int, Appeal> Appeals { get; } = new Dictionary<int, Appeal>();

        public void Create(Appeal appeal)
        {
            Appeals.Add(appeal.AppealId, appeal);
        }

        public Appeal Read(int appealId)
        {
            return Appeals[appealId];
        }

        public Appeal Update(int AppealId, Appeal newAppeal)
        {
            Appeals[AppealId] = newAppeal;
            return Appeals[AppealId];
        }

        public bool Delete(int AppealId)
        {
            return Appeals.Remove(AppealId);
        }
    }
}
```

Хранилище Клиентов:

```csharp
using newsait.Domains;
using System.Collections.Generic;

namespace newsait.Repository
{
    public class ClientStorage
    {
        private Dictionary<int, Client> Clients { get; } = new Dictionary<int, Client>();

        public void Create(Client client)
        {
            Clients.Add(client.ClientId, client);
        }

        public Client Read(int clientId)
        {
            return Clients[clientId];
        }

        public Client Update(int clientId, Client newClient)
        {
            Clients[clientId] = newClient;
            return Clients[clientId];
        }

        public bool Delete(int clientId)
        {
            return Clients.Remove(clientId);
        }
    }
}
```

***

Так же по представленным диаграммам были разработанны контроллеры, применяемые для взаимодействия с клиентом: контроллер Клиента, контроллер Оператора, контроллер Вет. Диетолога и контроллер Вет. Врача.

Примеры кода контроллеров:

Контроллер Клиента:
```csharp
/////////////////////////////////////////////////
```

Контроллер Оператора:
```csharp
/////////////////////////////////////////////////
```

<a name="check"/>

## 4 Проверка качества

<a name="litr"/>

## Список использованных источников

1. https://ru.wikipedia.org/wiki/%D0%9D%D0%B0%D1%81%D0%B5%D0%BB%D0%B5%D0%BD%D0%B8%D0%B5_%D0%A0%D0%BE%D1%81%D1%81%D0%B8%D0%B8
2. https://www.vetusklinika.ru/article/veterinary/care/
3. https://enjoy-job.ru/professions/dietolog/
4. https://docdoc.ru/library/terapevtiya/chto-lechit-vrach-terapevt
5. http://www.chelagro.ru/about/subordinated/goals_and_objectives_of_veterinary_institutions.php
6. https://www.blizko.ru/products/38439-besplatnaya_konsultatsiya_veterinara_po_telefonu_s_8_00_do_22_00
7. https://www.vet-vrn.ru/services/onlayn-konsultatsiya/
8. https://bio-vet.ru/uslugi/zhivotnye/konsultatsiya-veterinara-online.html
9. https://vet-dok.ru/vopros-otvet.html
10. https://zoopt.ru/contacts/vetkonsultant/?utm_source=google&utm_medium=cpc&utm_campaign=
11. https://vetmanager.ru/
12. http://vetdesk.ru/
13. http://www.vetsoft.ru/
14. http://www.edliny.ru/vetprog/
