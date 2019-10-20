$(function () {

    $("#ReminderDate").datepicker(

        {
            onChangeMonthYear: function (y, m, i)
            {
                var d = i.selectedDay;
                $(this).datepicker("setDate", new Date(y, m-1, d));
            },
            yearRange: "-1:+3",
            changeMonth: true,
            changeYear: true
        }
    );
    $("#StartDate").datepicker(

        {
            onChangeMonthYear: function (y, m, i) {
                var d = i.selectedDay;
                $(this).datepicker("setDate", new Date(y, m - 1, d));
            },
            yearRange: "2010:+3",
            changeMonth: true,
            changeYear: true
        }
    );
    $("#PaymentDate").datepicker(

        {
            onChangeMonthYear: function (y, m, i) {
                var d = i.selectedDay;
                $(this).datepicker("setDate", new Date(y, m - 1, d));
            },
            yearRange: "2010:+3",
            changeMonth: true,
            changeYear: true
        }
    );
    $("#DateOfBirth").datepicker(

        {
            onChangeMonthYear: function (y, m, i) {
                var d = i.selectedDay;
                $(this).datepicker("setDate", new Date(y, m - 1, d));
            },
            yearRange: "-50:-15",
            changeMonth: true,
            changeYear: true
        }
    );
})