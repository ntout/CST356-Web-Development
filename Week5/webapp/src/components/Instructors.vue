<template>
    <div>
        <h4 class="table-list">Instructors</h4>
        <div class="container">
            <table id="instructor-list" class="table"> 
                <tr>    
                    <th>First Name</th>
                    <th>Middle Initial</th>
                    <th>Last Name</th>
                </tr>
                <tr v-for="instructor in instructors" v-bind:key="instructor">
                    <td>{{ instructor.firstName }}</td>
                    <td>{{ instructor.middle }}</td>
                    <td>{{ instructor.lastName }}</td>
                </tr>
            </table>
        </div>
    </div>
</template>


<script>
    export default {
        name: 'Instructors',
        mounted(){
            this.instructors = getInstructors()
        },
        data() {
            return {
                instructors: []
            }
        }
    }

    function getInstructors() {
        return JSON.parse(instructors);
    }

    var instructors = '[{"firstName": "Jim", "middle": "Q", "lastName": "Callison"},{"firstName": "Jordon", "middle": "D", "lastName": "Thomas"},{"firstName": "Scott", "middle": "S", "lastName": "Stirts"},{"firstName": "Emily", "middle": "L", "lastName": "Peterson"}]';
</script>


<style scoped>
    table, th, td {
        padding: 10px;
        border: 2px solid black; 
        border-collapse: collapse;
    }
</style>
