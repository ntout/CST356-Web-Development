var students = '{"students": [{"id": 10001, "email": "joe@aol.com"},{"id": 10002, "email": "jim@juno.com"},{"id": 10003, "email": "susan@aol.com"},{"id": 10004, "email": "sarah@gmail.com"}]}'

function JsonToArray(s){
    return JSON.parse(s)
}

function initializeStudents() {
    var data = JsonToArray(students);
    for (let i = 0; i < data["students"].length; i++) {
        var id = data["students"][i].id;
        var email = data["students"][i].email;
        $('#student-list').append("<tr><td>" + id + "</td><td>" + email + "</td></tr>")
    }
}   


// $("#stu-test").click(function(){
//     console.log("test clicked");
//     var data = JsonToArray(students);
//     console.log(data["students"].length)
//     for (let i = 0; i < data["students"].length; i++) {
//         var id = data["students"][i].id;
//         var email = data["students"][i].email;
//         $('#student-list').append("<tr><td>" + id + "</td><td>" + email + "</td></tr>")
//     }
// })


