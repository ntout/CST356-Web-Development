<template>
    <div>
        <h4 class="table-list">Students</h4>
        <table id="student-list" class="table">
            <tr>    
                <th>Student ID</th>
                <th>Email Address</th>
            </tr>
            <tr v-for="student in students" v-bind:key="student">
                <td>{{ student.id }}</td>
                <td>{{ student.email }}</td>
            </tr>
        </table>
    </div>
</template>


<script>
    export default {
        name: 'Students',
        mounted(){
            this.students = getStudents()
        },
        data() {
            return {
                students: []
            }
        }
    }   

    function getStudents() {
        return JSON.parse(students);
    }

    var students = '[{"id": 10001, "email": "joe@aol.com"},{"id": 10002, "email": "jim@juno.com"},{"id": 10003, "email": "susan@aol.com"},{"id": 10004, "email": "sarah@gmail.com"}]'
</script>


<style scoped>
    table, th, td {
        padding: 10px;
        border: 2px solid black; 
        border-collapse: collapse;
    }
</style>
