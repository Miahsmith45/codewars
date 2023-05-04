// https://www.codewars.com/kata/56c22c5ae8b139416c00175d/train/javascript

function match(candidate, job) {
    if (!candidate.minSalary || !job.maxSalary) throw "Invalid Job or Candidate";
     return job.maxSalary >= candidate.minSalary * 0.9;
   }