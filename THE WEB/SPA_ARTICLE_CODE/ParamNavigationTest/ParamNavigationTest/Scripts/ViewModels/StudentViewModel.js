/// <reference path="../knockout-2.1.0.debug.js" />

// change course to course not to be confused with js courses.

function Student(name, courses) {
    var self = this;
    self.name = name;

    self.selectedCourse = ko.observable("");

    self.selectCourse = function (acourse) {
        self.selectedCourse(acourse);
    };

    self.courses = courses;
}

var studentVM = {
    students: [
        new Student("John", [
            {
                courseName: "Algebra",
                grade: "A"
            },
            {
                courseName: "English",
                grade: "B"
            }
        ]),
        new Student("Sam", [
            {
                courseName: "Geometry",
                grade: "C"
            },
            {
                courseName: "English",
                grade: "A"
            }
        ])
    ],

    selectedStudent: ko.observable(""),

    selectStudent: function (student) {
        studentVM.selectedStudent(student);
    }
};

studentVM.hasSelectedCourse = ko.computed(function () {
    var selectedStudent = this.selectedStudent();

    if (!selectedStudent)
        return false;

    var selectedCourse = selectedStudent.selectedCourse();

    if (!selectedCourse) {
        return false;
    }

    return true;
}, studentVM);