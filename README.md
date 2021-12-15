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
 
 ***
 
<a name="description"/>

## 1 Описание предметной области
 
Число пациентов в ветеринарных клиниках с каждым годом только увеличивается. В результате, в последнее время ветеринары все чаще сталкиваются с такими заболеваниями, которые раньше практически не встречались. Таким образом, постепенно расширяется спектр услуг. Повышается статус ветеринарного врача. В частном сегменте рынка ветеринарных услуг наблюдаются прогрессивные тенденции. Появляется значительное количество частных ветеринарных клиник и лабораторий, предоставляющих платные лечебные и диагностические услуги.

Консультации и приемы в вет. клиниках ведут одновременно несколько ветеринарных врачей разных специальностей, таких как врач-диетотог(это врач, который занимается вопросами безопасного, физиологически сбалансированного питания для здоровых пациентов и лечебного — для больных) и врач-терапевт(это специалист широкого профиля, в его компетенции находятся вопросы ранней диагностики и лечения многих заболеваний), выполняющих диагностику животных с последующей разработкой плана питания или плана лечения, в зависимости от специфики проблемы. Регистратура является центральным, связующим звеном в работе всей клиники и координирует работу ветспециалистов. 

Современная ветеринарная клиника – это сложная организационная структура, и от участия каждого сотрудника зависит стабильность работы лечебного учреждения. Это скрытая часть айсберга, которую не должен явно замечать обратившийся в ветеринарную клинику владелец больного животного. Темп жизни современного человека заставляет его прикладывать максимальные усилия для анализа и учета информации, а сложнее всего это делать при ее непрерывном потоке, с чем и сталкиваются руководство и сотрудники многих клиник, особенно отдела регистратуры. Эффективность функционирования предприятия или организации любой отрасли и сферы деятельности напрямую зависит от скорости, точности и своевременности обмена данными как внутри этого предприятия между его составляющими частями, так и вне его, то есть взаимодействие и обмен данными этой организации с клиентами. 

Для качественного решения подобных проблем на предприятиях используются автоматизированные системы управления (АСУ). Автоматизированная система управления – это человеко-машинная система, обеспечивающая автоматизированный сбор и обработку информации, необходимой для оптимизации управления в различных сферах человеческой деятельности. 
Актуальность данной работы заключается в необходимости комплексной автоматизации всех подразделений ветеринарной клиники. Целью является разработка и воплощение системы автоматизации ветеринарной клиники, позволяющей увеличить производительность труда всех сотрудников, повысить качество, скорость и своевременность обслуживания клиентов и усилить контроль над всеми этапами трудовой деятельности специалистов клиники. 

***

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

***

<a name="design"/>

## 3 Разработка системы

В процессе проектирования системы, изначально была разработанна диаграмма вариантов использования. В результате анализа предметной области было определено 4 сущности: клиент, оператор, вет. диетолог и вет. врач. 

Рассмотрим функции каждой из сущностей.
Сущность-Клиент может подавать обращение в организацию, в процессе заполняя сведения о животном, и получать ответ на свое обращение от организации.
Сущность-Оператор может принимать обращение от клиента, в процессе выбирая специалиста, который будет решать проблему, описанную в обращении. Так же сущность-Оператор может получать заключения от специалистов и следовательно оповещать о результатах клиента.
Сущность-Вет. диетолог может рассматривать обращение, составлять по нему заключение, в процессе составляя план питания.
Сущность-Вет. врач, так же как и Вет. диетолог рассматривает обращение, составляет по нему заключение, но только составляя уже план лечения.

<p align="center">
<img src=https://user-images.githubusercontent.com/91088733/144324826-84dbae52-c5ce-441f-8bb2-9f63b6870ab1.png>
<p align="center">Рисунок 1 - Диаграмма вариантов использования</p>  

***

Далее была разработанна диаграмма потоков данных. В результате анализа предметной области были определены основные сущности данных и действия, требующие взаимодействия с этими сущностями.

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

Последняя разработанная диаграмма - это диаграмма отношений. В результате анализа предметной области были выявлены следующие сущности: вид, порода, и пол животного, клиент, животное, статус обращения, обращение, заключение, доктор, должность и услуга доктора, симптоматика заболевания, заболевание, симптомы, рекомендации, метод лечения, и диагноз.

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

По представленным диаграммам были разработанны следующие классы: 

<p align="center">
<img src=https://user-images.githubusercontent.com/91088733/146240851-a2ddc1f2-4c94-42bf-a5a6-9d8a4e35b7cf.png>
<p align="center">Рисунок 4 - Список классов</p>  

Пример кода класса "Обращение":

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

Пример кода класса "Клиент":

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

Так же по представленным диаграммам были разработанны хранилища, которые позволяют создавать, хранить, актуализировать и использовать информацию в системе:

<p align="center">
<img src=https://user-images.githubusercontent.com/91088733/146242144-5a9850b5-7aaa-43de-9611-b75b58e6c92c.png>
<p align="center">Рисунок 5 - Список хранилищ</p> 

Пример кода хранилища обращений:

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

Пример кода хранилища клиентов:

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

Так же по представленным диаграммам были разработанны контроллеры, применяемые для взаимодействия с клиентом: 

<p align="center">
<img src=https://user-images.githubusercontent.com/91088733/146242461-e745ae2d-08e6-465d-9cbe-4ba88872cc1d.png>
<p align="center">Рисунок 6 - Список контроллеров</p> 

Пример кода контроллера клиента:
```csharp
using Microsoft.AspNetCore.Mvc;
using newsait.Domains;
using newsait.Repository;

namespace newsait.Controllers
{
    [ApiController]
    [Route("/clienti")]
    public class ClientController : ControllerBase
    {
        [HttpPut("Registration")]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return client;
        }

        [HttpGet("Avtorization")]
        public Client Read(int clientId)
        {
            return Storage.ClientStorage.Read(clientId);
        }

        [HttpPut("AddPet")]
        public Pet Create(Pet pet)
        {
            Storage.PetStorage.Create(pet);
            return pet;
        }

        [HttpGet("ChoisePet")]
        public Pet Read3(int PetId)
        {
            return Storage.PetStorage.Read(PetId);
        }

        [HttpGet("ViewAppeal")]
        public Appeal Read1(int appealId)
        {
            return Storage.AppealStorage.Read(appealId);
        }

        [HttpGet("ViewConclusion")]
        public Conclusion Read2(int conclusionId)
        {
            return Storage.ConclusionStorage.Read(conclusionId);
        }

        [HttpPut("CreatedAppeal")]
        public Appeal Create1(Appeal appeal)
        {
            Storage.AppealStorage.Create(appeal);
            return appeal;
        }
    }
}
```

Пример кода контроллера вет. диетолога:
```csharp
using Microsoft.AspNetCore.Mvc;
using newsait.Domains;
using newsait.Repository;

namespace newsait.Controllers
{
    [ApiController]
    [Route("/vetDiet")]
    public class VetDietController : ControllerBase
    {
        [HttpGet("ChoiceService")]
        public Service Read(int ServiceId)
        {
            return Storage.ServiceStorage.Read(ServiceId);
        }

        [HttpGet("ChoiceIll")]
        public Ill Read1(int IllId)
        {
            return Storage.IllStorage.Read(IllId);
        }

        [HttpPatch("CompleteConclusion")]
        public Conclusion Update2(int ConclusionId, Conclusion newConclusion)
        {
            return Storage.ConclusionStorage.Update(ConclusionId, newConclusion);
        }
    }
}
```

***

<a name="check"/>

## 4 Проверка качества

После запуска программы открывается страница Swagger UI со списком контроллеров и их операциями над сущностями (рисунок 7).

<p align="center">
<img src=https://user-images.githubusercontent.com/91088733/146261277-db2cd50f-b1db-4553-95ad-e5fd85c0fe55.PNG>
<p align="center">Рисунок 7 - Список контроллеров</p> 

Проверка работы методов CRUD (Create - создание, Read - чтение, Update - обновление, Delete - удаление) в контроллере Operator (рисунок 8).

<p align="center">
<img src=https://user-images.githubusercontent.com/91088733/146263260-de0cbdca-815a-4d29-b307-219b74d660bb.png>
<p align="center">Рисунок 8 - Список методов контроллера Operator</p> 

1) Create позволяет добавлять новую запись в хранилище (рисунок 9).
<p align="center">
<img src=https://user-images.githubusercontent.com/91088733/146264366-d206b17f-56f3-47a9-9d2f-04d86a80cfb6.png></p>
<p align="center">Рисунок 9 - Окно метода Create в которое вносим значения полей новой записи</p> 

После успешного выполнения операции сервер выдаёт ответ (см. рисунок 8).
<p align="center">
<img src=https://user-images.githubusercontent.com/91088733/146264541-254e8d86-d38a-496b-be75-33a060d451ec.png></p>
<p align="center">Рисунок 10 - Результат выполнения метода Create</p> 

2) Функция чтения Read похожа на функцию поиска, поскольку позволяет извлекать определенные записи и считывать их значения (см. рисунок 9).
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144922014-0977f496-d0d0-4cbf-98f4-1f01a03dffea.png"></p>
<p align="center">Рисунок 9 - Окно функции чтения</p> 

Считывание информации об уже созданном авторе по его Id (см. рисунок 10).
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144922348-b7a0767c-0361-4c1c-bd7c-d65c7f601e52.png"></p>
<p align="center">Рисунок 10 - Работа с методом чтения</p> 

После выполнения операции сервер выдаёт об авторе информацию, которая была создана в Create (см. рисунок 11).
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144922666-7bfb2b20-e437-44c0-854c-d348933175c7.png"></p>
<p align="center">Рисунок 11 - Результат выполнения операции чтения</p> 

3) Update, редактирование записи (см. рисунок 12). Используется для изменения существующих записей в базе данных.
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144923637-12647088-b199-41c0-a05b-a241792af51a.png"></p>
<p align="center">Рисунок 12 - Окно метода обновления</p> 

Измениение информации об авторе, для этого сначала нужно ввести его номер и затем новые данные (см. рисунок 13).
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144923909-f62104f4-1e1f-41b8-bd9b-ca44a12700e1.png"></p>
<p align="center">Рисунок 13 - Работа с методом обновления</p> 

После выполнения операции сервер выдаёт новую информацию о том же авторе (см. рисунок 14).
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144924009-de2ef562-69bc-4204-8e82-19374ac1709f.png"></p>
<p align="center">Рисунок 14 - Результат выполнения операции обновления</p> 

Функцией read проверка вышеуказанной операции. После срабатывания сервер выдает новую информацию об авторе (см. рисунок 15).
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144924494-d98e66c5-0a49-4520-85e8-bc9465a5a98c.png"></p>
<p align="center">Рисунок 15 - Результат выполнения операции чтения после обновления данных</p> 

4) Delete - используется для удаления записи по Id. Если операция удаления сработает успешно, то ответ сервера будет "true", иначе "false" (см. рисунок 16).
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144926022-93826b7d-8fbc-40b5-b56c-613c875e9cbd.png"></p>
<p align="center">Рисунок 16 - Окно метода удаления</p> 

Удаление автора по его Id (см. рисунок 17).
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144926674-fb94a0ac-c3f5-447d-8c38-3c6c53974b15.png"></p>
<p align="center">Рисунок 17 - Работа с методом удаления</p> 

После выполнения операции ответ сервера (см. рисунок 18)
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144927692-77abb517-f2e7-43d9-8d25-a13c5bb51fe3.png"></p>
<p align="center">Рисунок 18 - Раезультат выполнения метода удаления</p> 

Проверка вышеописанного действия с помощью read, считывание информацию об удалённом авторе (см. рисунок 19).
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144929588-96e2f936-87dd-4f09-8a69-c0f7571bf3ea.png"></p>
<p align="center">Рисунок 19 - Работа с операцией чтения</p> 

После срабатывания программа не выдаёт информации об этом авторе (см. рисунок 20).
<p align="center">
<img src="https://user-images.githubusercontent.com/90477769/144929380-5666d528-52ec-46fa-979e-cd3a4db56fd9.png"></p>
<p align="center">Рисунок 20 - Результат выполнения операции чтения после удаления данных</p> 


***

<a name="litr"/>

## Список использованных источников

[1] Население России. Wikipedia [Электронный ресурс]. – Режим доступа: https://ru.wikipedia.org/wiki/%D0%9D%D0%B0%D1%81%D0%B5%D0%BB%D0%B5%D0%BD%D0%B8%D0%B5_%D0%A0%D0%BE%D1%81%D1%81%D0%B8%D0%B8, свободный (дата обращения: 30.09.2021).

[2] ВЕТЕРИНАРНАЯ КЛИНИКА "ВЕТУС". Vetusklinika [Электронный ресурс]. – Режим доступа: https://www.vetusklinika.ru/article/veterinary/care/, свободный (дата обращения: 08.10.2021).

[3] Профессия диетолог. Enjoy-job [Электронный ресурс]. – Режим доступа: https://enjoy-job.ru/professions/dietolog/, свободный (дата обращения: 20.10.2021).

[4] Что лечит врач-терапевт? Docdoc [Электронный ресурс]. – Режим доступа: https://docdoc.ru/library/terapevtiya/chto-lechit-vrach-terapevt, свободный (дата доступа: 5.11.2021).

[5] Цели, задачи и предмет деятельности учреждений ветеринарии. Chelagro [Электронный ресурс]. – Режим доступа: http://www.chelagro.ru/about/subordinated/goals_and_objectives_of_veterinary_institutions.php, свободный (дата доступа: 05.11.2021).

[6] Топ 10: Программы для ветеринарных клиник. Livemedical [Электронный ресурс]. – Режим доступа: https://www.livemedical.ru/tools/vet/, свободный (дата доступа: 07.11.2021).
