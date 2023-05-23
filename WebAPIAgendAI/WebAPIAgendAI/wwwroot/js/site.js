// Initialization: current year and month
const dateObj = new Date();
let year = dateObj.getFullYear();
let month = dateObj.getMonth() + 1;
const day = dateObj.getDate();

// Months names
const monthName = [
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December"
];

let date; //= new Date(`${monthName[month - 1]} 1 ${year}`);
let startDay; //= date.getDay() == 0 ? 7 : date.getDay();

let previousMonthDays; // = new Date(year, month - 1, 0).getDate();
let currentMonthDays; //= new Date(year, month, 0).getDate();
let nextMonthDays; //= new Date(year, month == 12 ? 1 : month + 1, 0).getDate();

let offset; //= startDay <= 7 ? startDay : startDay - 7;
let previousMonthOffset; // = offset - 1;
let nextMonthOffset; //= 42 - previousMonthOffset - currentMonthDays;
let selectedDay = null;

//-----> Teste
const testDate = _ => {
    const idDay = day < 10 ? `0${day}` : day;
    const idMonth = month < 10 ? `0${month}` : month;
    return `${year}-${idMonth}-${idDay}`;
};
const events = [
    { name: "Kaliane", date: testDate(), email: "Kaliane@AgendAI", tag: "Aula" },
    { name: "Victor", date: testDate(), email: "Victor@AgendAI", tag: "Prova" },
    { name: "Thais", date: testDate(), email: "Thais@AgendAI", tag: "Atualizacao" },
    { name: "Thiago", date: testDate(), email: "Thiago@AgendAI", tag: "Evento" }
];
//----> Fim do teste

// Seletores basicos para DOM
const calendarContainer = document.querySelector(".calendar");
const monthsList = document.querySelector(".months");
const yearsList = document.querySelector(".years");

const clearDOM = _ => {
    calendarContainer.innerHTML = "";
    monthsList.innerHTML = "";
    yearsList.innerHTML = "";
};

const calculateDate = display => {
    if (display == "months") {
        document.getElementById("showYears").textContent = `${year}`;
    } else if (display == "years") {
        document.getElementById("showYears").textContent = `${year} - ${year + 16}`;
    } else {
        document.getElementById("showMonths").textContent = `${monthName[month - 1]
            } ${year}`;
    }

    date = new Date(`${monthName[month - 1]} 1 ${year}`);
    startDay = date.getDay() == 0 ? 7 : date.getDay();

    previousMonthDays = new Date(year, month - 1, 0).getDate();
    currentMonthDays = new Date(year, month, 0).getDate();
    nextMonthDays = new Date(year, month == 12 ? 1 : month + 1, 0).getDate();

    offset = startDay <= 7 ? startDay : startDay - 7;
    previousMonthOffset = offset - 1;
    nextMonthOffset = 42 - previousMonthOffset - currentMonthDays;

    createCalendar();
};

const goToPrevious = _ => {
    clearDOM();

    if (
        document.querySelector(".calendar").style.display == "none" &&
        document.querySelector(".years").style.display == "none"
    ) {
        year--;
        calculateDate("months");
    } else if (
        document.querySelector(".calendar").style.display == "none" &&
        document.querySelector(".months").style.display == "none"
    ) {
        year -= 16;
        calculateDate("years");
        createYears();
    } else {
        if (month == 1) {
            month = 12;
            year--;
        } else {
            month--;
        }
        calculateDate("calendar");
    }
};

const goToNext = _ => {
    clearDOM();

    if (
        document.querySelector(".calendar").style.display == "none" &&
        document.querySelector(".years").style.display == "none"
    ) {
        year++;
        calculateDate("months");
    } else if (
        document.querySelector(".calendar").style.display == "none" &&
        document.querySelector(".months").style.display == "none"
    ) {
        year += 16;
        calculateDate("years");
        createYears();
    } else {
        if (month == 12) {
            month = 1;
            year++;
        } else {
            month++;
        }
        calculateDate("calendar");
    }
};

const selectDay = (calendarDay, i) => {
    const selected = document.getElementsByClassName("isSelected");
    [...selected].forEach(element => element.classList.remove("isSelected"));
    calendarDay.classList.add("isSelected");
    selectedDay = calendarDay.getAttribute("id");

    const asideDay = document.querySelector(".side-info-num");
    const asideMonth = document.querySelector(".side-info-month");
    const asideYear = document.querySelector(".side-info").lastElementChild;

    asideYear.innerHTML = year;
    asideDay.innerHTML = i - offset + 1;
    asideMonth.innerHTML = monthName[month - 1];

    listEventsForSelectedDay();
};

const dateFormat = (offset, i) => {
    const day = i - offset + 1;
    const idDay = day < 10 ? `0${day}` : day;
    const idMonth = month < 10 ? `0${month}` : month;
    return `${year}-${idMonth}-${idDay}`;
};

const listEventsForSelectedDay = _ => {
    const eventList = document.querySelector("#eventList");
    eventList.innerHTML = "";

    if (events.length > 0) {
        events
            .filter(event => event.date == selectedDay)
            .forEach(event => {
                const eventNode = document.createElement("p");
                eventNode.classList.add("side-bar-event");
                switch (event.tag) {
                    case "Evento":
                        eventNode.classList.add("side-bar-event-Evento");
                        break;

                    case "Prova":
                        eventNode.classList.add("side-bar-event-Prova");
                        break;

                    case "Atualizacao":
                        eventNode.classList.add("side-bar-event-Atualizacao");
                        break;

                    default:
                        eventNode.classList.add("side-bar-Aula");
                        break;
                }
                eventNode.innerHTML = `${event.name} <span> • 
        ${event.email} 
        • ${event.date}  •${event.Sala}  •${event.Quantidade}</span>`;
                eventList.appendChild(eventNode);
            });

        // Tipo do uso
        const days = document.getElementsByClassName("current-month-day");
        [...days].forEach(day => {
            events.forEach(event => {
                if (day.getAttribute("id") == event.date) {
                    const eventNode = document.createElement("div");
                    eventNode.classList.add("event");
                    switch (event.tag) {
                        case "Evento":
                            eventNode.classList.add("event-Evento");
                            break;

                        case "Prova":
                            eventNode.classList.add("event-Prova");
                            break;

                        case "Atualizacao":
                            eventNode.classList.add("event-Atualizacao");
                            break;

                        default:
                            eventNode.classList.add("Aula");
                            break;
                    }
                    day.appendChild(eventNode);
                }
            });
        });
    }
};

const createCalendar = _ => {
    // Dias da semana
    const weekDays = ["SEG", "TER", "QUA", "QUI", "SEX", "SAB", "DOM"];
    weekDays.forEach((element, index) => {
        const weekDay = document.createElement("div");
        const weekDayName = document.createElement("p");
        weekDay.classList.add("week-day");
        weekDay.style.gridArea = `day${index + 1}`;

        weekDayName.innerHTML = element;
        weekDay.appendChild(weekDayName);

        calendarContainer.appendChild(weekDay);
    });

    // previw mes
    if (previousMonthOffset > 0) {
        let previousMonthDayNumOffset = previousMonthOffset;
        for (let i = 0; i < previousMonthOffset; i++) {
            const calendarDay = document.createElement("div");
            const calendarDayNumber = document.createElement("p");
            calendarDay.classList.add("previous-month-day");
            calendarDay.style.gridArea = `day${i + 8}`;

            calendarDayNumber.innerHTML =
                previousMonthDays - previousMonthDayNumOffset + 1;
            calendarDay.appendChild(calendarDayNumber);

            calendarContainer.appendChild(calendarDay);
            previousMonthDayNumOffset--;
        }
    }


    for (let i = offset; i < currentMonthDays + offset; i++) {
        const calendarDay = document.createElement("div");
        const calendarDayNumber = document.createElement("p");

        if (i % 7 == 0 && i - offset + 1 != day) {
            calendarDay.classList.add("current-month-day");
            calendarDayNumber.classList.add("sundays");
        } else if (
            i - offset + 1 == day &&
            year == new Date().getFullYear() &&
            month == new Date().getMonth() + 1
        ) {

            calendarDay.classList.add("current-month-day");
            if (selectedDay === null) {
                const selected = document.getElementsByClassName("isSelected");
                [...selected].forEach(element =>
                    element.classList.remove("isSelected")
                );
                calendarDay.classList.add("isSelected");
                selectDay(calendarDay, i);
                selectedDay = dateFormat(offset, i);
            }
        } else {
            calendarDay.classList.add("current-month-day");
        }

        calendarDay.style.gridArea = `day${i + 7}`;

        calendarDayNumber.innerHTML = i - offset + 1;
        calendarDay.setAttribute("id", dateFormat(offset, i));
        calendarDay.appendChild(calendarDayNumber);

        if (calendarDay.getAttribute("id") == selectedDay) {
            calendarDay.classList.add("isSelected");
        }

        calendarContainer.appendChild(calendarDay);

        calendarDay.addEventListener("click", _ => {
            selectDay(calendarDay, i);
        });

        listEventsForSelectedDay();
    }

    // proximo mes
    if (nextMonthOffset > 0) {
        for (let i = 0; i < nextMonthOffset; i++) {
            const calendarDay = document.createElement("div");
            const calendarDayNumber = document.createElement("p");

            calendarDay.classList.add("next-month-day");
            calendarDay.style.gridArea = `day${i +
                8 +
                previousMonthOffset +
                currentMonthDays}`;

            calendarDayNumber.innerHTML = i + 1;
            calendarDay.appendChild(calendarDayNumber);

            calendarContainer.appendChild(calendarDay);
        }
    }
};

const chooseMonth = choosenMonth => {
    month = choosenMonth;
    document.getElementById("showMonths").style.display = `inline-block`;
    document.getElementById("showYears").style.display = `none`;
    calendarContainer.style.display = "grid";
    monthsList.style.display = "none";

    document.getElementById("showMonths").textContent = `${monthName[month - 1]
        } ${year}`;

    calculateDate(true);
};

const showMonths = choosenYear => {
    if (choosenYear !== null) {
        year = choosenYear;
    }

    clearDOM();

    document.getElementById("showMonths").style.display = `none`;
    document.getElementById("showYears").style.display = `inline-block`;
    document.getElementById("showYears").disabled = false;
    document.getElementById("showYears").textContent = `${year}`;

    calendarContainer.style.display = "none";
    monthsList.style.display = "grid";
    yearsList.style.display = "none";

    for (let i = 0; i < 12; i++) {
        const calendarMonth = document.createElement("div");
        const calendarMonthName = document.createElement("p");

        calendarMonth.classList.add("current-month-day");
        calendarMonth.style.gridArea = `mon${i + 1}`;

        calendarMonthName.innerHTML = monthName[i].substring(0, 3);
        calendarMonth.appendChild(calendarMonthName);

        monthsList.appendChild(calendarMonth);

        calendarMonth.addEventListener("click", _ => chooseMonth(i + 1), false);
    }
};

const showYears = _ => {
    document.getElementById("showMonths").style.display = `none`;
    document.getElementById("showYears").style.display = `inline-block`;
    document.getElementById("showYears").disabled = true;
    document.getElementById("showYears").textContent = `${year} ${year + 4}`;

    calendarContainer.style.display = "none";
    yearsList.style.display = "grid";
    monthsList.style.display = "none";

    createYears();
};

const createYears = _ => {
    clearDOM();

    for (let i = 0; i < 16; i++) {
        const calendarYear = document.createElement("div");
        const calendarYearName = document.createElement("p");

        calendarYear.classList.add("current-month-day");
        calendarYear.style.gridArea = `year${i + 1}`;

        calendarYearName.innerHTML = year + i;
        calendarYear.appendChild(calendarYearName);

        yearsList.appendChild(calendarYear);

        calendarYear.addEventListener("click", _ => showMonths(year + i), false);
    }
};

// Evento popup
const showPopupEvent = _ => {
    const eventPopup = document.querySelector("#eventPopup");
    eventPopup.classList.add("isVisible");
    document.body.classList.add("overlay");

    const selected = document.querySelector(".isSelected");
    const day =
        selected.firstElementChild.innerText < 10
            ? `0${selected.firstElementChild.innerText}`
            : selected.firstElementChild.innerText;
    document.querySelector('input[type="date"]').value =
        month < 10 ? `${year}-0${month}-${day}` : `${year}-${month}-${day}`;
};

const closePopup = _ => {
    const eventPopup = document.querySelector("#eventPopup");
    eventPopup.classList.remove("isVisible");
    document.body.classList.remove("overlay");
};

const createEvent = _ => {
    const element = event.target;
    const eventElement = document.createElement("div");
    eventElement.innerText = "Kukuriku";
    element.appendChild(eventElement);
};

// Eventos
const btnPreviousMonth = document.querySelector("#prev");
const btnNextMonth = document.querySelector("#next");
const btnShowMonths = document.querySelector("#showMonths");
const btnShowYears = document.querySelector("#showYears");
const btnToday = document.querySelector("#today");
const btnAddEvent = document.querySelector("#addEvent");
const btnClosePopup = document.querySelector("#closePopup");
const btnStoreEvent = document.querySelector("#storeEvent");

document.addEventListener("DOMContentLoaded", calculateDate);

btnPreviousMonth.addEventListener("click", goToPrevious);
btnNextMonth.addEventListener("click", goToNext);
btnShowMonths.addEventListener("click", _ => showMonths(null), false);
btnShowYears.addEventListener("click", showYears);
btnToday.addEventListener("click", _ => {
    clearDOM();
    year = new Date().getFullYear();
    month = new Date().getMonth() + 1;
    selectedDay = null;
    calculateDate();
});
btnAddEvent.addEventListener("click", showPopupEvent);
btnClosePopup.addEventListener("click", closePopup);


class Event {
    constructor(name, email, date, Sala, Quantidade, tag) {
        this.name = name;
        this.email = email;
        this.date = date;
        this.Sala = Sala;
        this.Quantidade = Quantidade;
        this.tag = tag;
    }

    static storeEvent(event) {
        events.push(event);
    }
}

btnStoreEvent.addEventListener("click", e => {
    const name = document.querySelector("input[name=name]").value;
    const date = document.querySelector("input[name=date]").value;
    const email = document.querySelector("textarea[name=email]").value;
    const Sala = document.querySelector("select[name=Sala]").value;
    const Quantidade = document.querySelector("select[name=Quantidade]").value;
    const tag = document.querySelector("select[name=tag]").value;

    const newEvent = new Event(name, date, email, Sala, Quantidade, tag);

    if (name === "" || date === "" || email === "" || Sala === "" || Quantidade === "" || tag === "") {
        alert("Please fill in all fields", "info");
        return;
    } else {
        Event.storeEvent(newEvent);
        closePopup();
    }
    listEventsForSelectedDay();
});

