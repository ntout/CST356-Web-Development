<template>
    <div>
        <h4 class="table-list">Students</h4>
        <table id="student-list" class="table">
            <tr>    
                <th>Student ID</th>
                <th>Email Address</th>
            </tr>
            <tr v-for="student in students" :key="student.Id">
                <td>{{ student.studentId }}</td>
                <td>{{ student.emailAddress }}</td>
            </tr>
        </table>
    </div>
</template>


<script>
    import Vue from 'vue'

    export default {
        name: 'Students',

        data() {
            return {
                students: [],
                operation: 'list',
                studentId: undefined,
                emailAddress: undefined,
                apiServer: process.env.VUE_APP_API_SERVER
            }
        },

        methods: {
            getStudents() {
                let url = `http://${this.apiServer}/api/student`;
                Vue.axios.get(url).then(
                    (response) => {
                        this.students = response.data;
                        console.log(this.students)
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            } ,

            getStudent: function(Id) {
                let url = `http://${this.apiServer}/api/student/${Id}`;
                Vue.axios.get(url).then(
                    (response) => {
                        this.studentId = response.data.studentId;
                        this.emailAddress = response.data.emailAddress;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
        },
        
        mounted(){
            this.getStudents(),
            this.operation = 'list'
        }
    }   

    //var students = '[{"id": 10001, "email": "joe@aol.com"},{"id": 10002, "email": "jim@juno.com"},{"id": 10003, "email": "susan@aol.com"},{"id": 10004, "email": "sarah@gmail.com"}]'
</script>


<style scoped>
    table, th, td {
        padding: 10px;
        border: 2px solid black; 
        border-collapse: collapse;
    }
</style>
