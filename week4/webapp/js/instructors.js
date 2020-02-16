var instructors = '{"instructors": [{"firstName": "Jim", "middle": "Q", "lastName": "Callison"},{"firstName": "Jordon", "middle": "D", "lastName": "Thomas"},{"firstName": "Scott", "middle": "S", "lastName": "Stirts"},{"firstName": "Emily", "middle": "L", "lastName": "Peterson"}]}'

function JsonToArray(s){
    return JSON.parse(s)
}

function initializeInstructors() {
    var data = JsonToArray(instructors);
    for (let i = 0; i < data["instructors"].length; i++) {
        var firstName = data["instructors"][i].firstName;
        var middle = data["instructors"][i].middle;
        var lastName = data["instructors"][i].lastName;
        $('#instructor-list').append("<tr><td>" + firstName + "</td><td>" + middle + "</td><td>" + lastName + "</td></tr>")
    }
}  


// $("#ins-test").click(function(){
//     console.log("test clicked");
//     var data = JsonToArray(instructors);
//     console.log(data["instructors"])
//     for (let i = 0; i < data["instructors"].length; i++) {
//         var first = data["instructors"][i].firstName;
//         var middle = data["instructors"][i].middle;
//         var last = data["instructors"][i].lastName;
//         $('#instructor-list').append("<tr><td>" + first + "</td><td>" + middle + "</td><td>" + last + "</td></tr>")
//     }
// })